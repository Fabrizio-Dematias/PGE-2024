using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;


namespace SpeechToTextApp
{
    public partial class MainWindow : Window
    {
        private SpeechRecognizer recognizer;
        private SpeechSynthesizer synthesizer;
        private bool isRecognizing = false;
        private string lastRecognizedText = "";
        private string detectedLanguage = "";
        private string audioFilePath = "../../recognized_audio.wav";

        private const string YourSubscriptionKey = "2ef9fcbc7af14b59bdfd1e27f7e42e6d";
        private const string YourRegion = "brazilsouth";

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var speechConfig = SpeechConfig.FromSubscription(YourSubscriptionKey, YourRegion);
            var autoDetectSourceLanguageConfig = AutoDetectSourceLanguageConfig.FromLanguages(new string[] { "en-US", "es-ES", "pt-BR", "de-DE" });

            using (var audioConfig = AudioConfig.FromDefaultMicrophoneInput())
            {
                recognizer = new SpeechRecognizer(speechConfig, autoDetectSourceLanguageConfig, audioConfig);

                recognizer.Recognizing += (s, eventArgs) =>
                {
                    Dispatcher.Invoke(() =>
                    {
                        TranscriptionTextBox.Text += $"{eventArgs.Result.Text}\n";
                    });
                };

                recognizer.Recognized += (s, eventArgs) =>
                {
                    if (!string.IsNullOrEmpty(eventArgs.Result.Text))
                    {
                        Dispatcher.Invoke(() =>
                        {
                            lastRecognizedText = eventArgs.Result.Text;

                            var autoDetectSourceLanguageResult = AutoDetectSourceLanguageResult.FromResult(eventArgs.Result);
                            var detectedLang = autoDetectSourceLanguageResult.Language;

                            TranscriptionTextBox.Text += $"{eventArgs.Result.Text}\n";
                            LanguageLabel.Content = $"Idioma detectado: {detectedLang}";
                            detectedLanguage = detectedLang;

                            UpdateFlag(detectedLang);
                            SpeakDetectedLanguage(detectedLang);
                        });
                    }
                };

                recognizer.Canceled += (s, eventArgs) =>
                {
                    MessageBox.Show($"Error: {eventArgs.ErrorDetails}");
                };

                recognizer.SessionStopped += (s, eventArgs) =>
                {
                    Dispatcher.Invoke(() =>
                    {
                        StartButton.IsEnabled = true;
                        StopButton.IsEnabled = false;
                    });
                };

                StartButton.IsEnabled = false;
                StopButton.IsEnabled = true;
                isRecognizing = true;

                await recognizer.StartContinuousRecognitionAsync();
            }
        }

        private void UpdateFlag(string languageCode)
        {
            string flagPath = "";

            switch (languageCode)
            {
                case "en-US":
                    flagPath = "C:\\Users\\fabri\\OneDrive\\Escritorio\\PGE-2024\\PGE-PARCIAL2\\Images\\us-flag.png";
                    break;
                case "es-ES":
                    flagPath = "C:\\Users\\fabri\\OneDrive\\Escritorio\\PGE-2024\\PGE-PARCIAL2\\Images\\spain-flag.png";
                    break;
                case "pt-BR":
                    flagPath = "C:\\Users\\fabri\\OneDrive\\Escritorio\\PGE-2024\\PGE-PARCIAL2\\Images\\brazil-flag.png";
                    break;
                case "de-DE":
                    flagPath = "C:\\Users\\fabri\\OneDrive\\Escritorio\\PGE-2024\\PGE-PARCIAL2\\Images\\germany-flag.png";
                    break;
            }

            if (File.Exists(flagPath))
            {
                LanguageFlag.Source = new BitmapImage(new Uri(flagPath));
            }
        }

        private async void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (isRecognizing)
            {
                await recognizer.StopContinuousRecognitionAsync();
                isRecognizing = false;
                StartButton.IsEnabled = true;
                StopButton.IsEnabled = false;
            }
        }

        private void HighlightLetter(char letter)
        {
            letter = char.ToUpper(letter);

            Label label = null;
            switch (letter)
            {
                case 'A': label = LetterA; break;
                case 'B': label = LetterB; break;
                case 'C': label = LetterC; break;
                case 'D': label = LetterD; break;
                case 'E': label = LetterE; break;
                case 'F': label = LetterF; break;
                case 'G': label = LetterG; break;
                case 'H': label = LetterH; break;
                case 'I': label = LetterI; break;
                case 'J': label = LetterJ; break;
                case 'K': label = LetterK; break;
                case 'L': label = LetterL; break;
                case 'M': label = LetterM; break;
                case 'N': label = LetterN; break;
                case 'Ñ': label = LetterÑ; break;
                case 'O': label = LetterO; break;
                case 'P': label = LetterP; break;
                case 'Q': label = LetterQ; break;
                case 'R': label = LetterR; break;
                case 'S': label = LetterS; break;
                case 'T': label = LetterT; break;
                case 'U': label = LetterU; break;
                case 'V': label = LetterV; break;
                case 'W': label = LetterW; break;
                case 'X': label = LetterX; break;
                case 'Y': label = LetterY; break;
                case 'Z': label = LetterZ; break;

            }

            // Si la letra fue encontrada, cambiar su color de fondo
            if (label != null)
            {
                label.Background = Brushes.Yellow;
                Task.Delay(1000).ContinueWith(_ =>
                {
                    Dispatcher.Invoke(() => label.Background = Brushes.White);
                });
            }
        }

        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lastRecognizedText))
            {
                var speechConfig = SpeechConfig.FromSubscription(YourSubscriptionKey, YourRegion);
                speechConfig.SpeechSynthesisVoiceName = GetVoiceForLanguage(detectedLanguage);
                synthesizer = new SpeechSynthesizer(speechConfig);

                // Deletrear el texto y resaltar letras
                foreach (char letter in lastRecognizedText)
                {
                    if (char.IsLetterOrDigit(letter))
                    {
                        HighlightLetter(letter);
                        await synthesizer.SpeakTextAsync(letter.ToString());
                    }
                    else if (char.IsWhiteSpace(letter))
                    {
                        await Task.Delay(500);
                    }
                }
            }
        }

        private string GetVoiceForLanguage(string language)
        {
            switch (language)
            {
                case "en-US": return "en-US-JennyNeural";
                case "es-ES": return "es-ES-ElviraNeural";
                case "pt-BR": return "pt-BR-FranciscaNeural";
                case "de-DE": return "de-DE-ConradNeural";
                default: return "en-US-JennyNeural";
            }
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lastRecognizedText))
            {
                var speechConfig = SpeechConfig.FromSubscription(YourSubscriptionKey, YourRegion);
                using (var audioOutput = AudioConfig.FromWavFileOutput(audioFilePath))
                {
                    var synthesizer = new SpeechSynthesizer(speechConfig, audioOutput);
                    await synthesizer.SpeakTextAsync(lastRecognizedText);
                    MessageBox.Show($"Archivo de audio guardado en {audioFilePath}");
                }

                var saveFileDialog = new Microsoft.Win32.SaveFileDialog
                {
                    FileName = "Transcription",
                    DefaultExt = ".txt",
                    Filter = "Text documents (.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, lastRecognizedText);
                }
            }
        }
        private async void SpeakDetectedLanguage(string language)
        {
            var speechConfig = SpeechConfig.FromSubscription(YourSubscriptionKey, YourRegion);
            speechConfig.SpeechSynthesisVoiceName = GetVoiceForLanguage(language);
            synthesizer = new SpeechSynthesizer(speechConfig);

            await synthesizer.SpeakTextAsync($"El idioma detectado es {language}");
        }
    }
}
