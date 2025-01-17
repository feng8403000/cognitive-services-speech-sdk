//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace MicrosoftSpeechSDKSamples
{
    class Program
    {
        /// <summary>
        /// Speech Recognition with Language Detection feature enabled
        /// </summary>
        private static void SpeechRecognitionWithLanguageDetectionEnabled()
        {
            Console.WriteLine("Please choose the following samples (with Language detection enabled)");
            var prompt = "Your choice (0: Stop): ";

            Console.WriteLine("1. Speech recognition with microphone input.");
            Console.WriteLine("2. Speech continuous recognition with multi-lingual audio input.");

            Console.Write(prompt);

            ConsoleKeyInfo x;
            x = Console.ReadKey();
            Console.WriteLine("");
            switch (x.Key)
            {
                case ConsoleKey.D1:
                    SpeechRecognitionWithLanguageIdSamples.RecognitionWithMicrophoneAsync().Wait();
                    break;
                case ConsoleKey.D2:
                    SpeechRecognitionWithLanguageIdSamples.MultiLingualRecognitionWithUniversalV2Endpiont().Wait();
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("\nExecution done. " + prompt);
        }

        /// <summary>
        /// Language Detection (SourceLanguageRecognizer) samples
        /// </summary>
        private static void LanguageDetectionSamples()
        {
            var prompt = "Your choice (0: Stop): ";

            Console.WriteLine("1. Language detection with microphone input.");
            Console.WriteLine("2. SingleShot language detection with file input.");
            Console.WriteLine("3. Continuous language detection with multi-lingual audio input.");

            Console.Write(prompt);

            ConsoleKeyInfo x;
            x = Console.ReadKey();
            Console.WriteLine("");
            switch (x.Key)
            {
                case ConsoleKey.D1:
                    StandaloneLanguageDetectionSamples.DetectionWithMicrophoneAsync().Wait();
                    break;
                case ConsoleKey.D2:
                    StandaloneLanguageDetectionSamples.LanguageDetectionWithFileAsync().Wait();
                    break;
                case ConsoleKey.D3:
                    StandaloneLanguageDetectionSamples.ContinuousLanguageDetectionWithFileAsync().Wait();
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("\nExecution done. " + prompt);
        }

        /// <summary>
        /// Translation with language detection enabled.
        /// </summary>
        private static void TranslationWithLanguageDetectionEnabled()
        {
            Console.WriteLine("Please choose the following samples (with Language detection enabled)");
            var prompt = "Your choice (0: Stop): ";

            Console.WriteLine("1. Translation with microphone input.");
            Console.WriteLine("2. Translation with multi-lingual audio input.");

            Console.Write(prompt);

            ConsoleKeyInfo x;
            x = Console.ReadKey();
            Console.WriteLine("");
            switch (x.Key)
            {
                case ConsoleKey.D1:
                    TranslationSamples.TranslationWithMicrophoneAsync_withLanguageDetectionEnabled().Wait();
                    break;
                case ConsoleKey.D2:
                    TranslationSamples.TranslationWithMultiLingualFileAsync_withLanguageDetectionEnabled().Wait();
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("\nExecution done. " + prompt);
        }

        /// <summary>
        /// Speech recogntion with Microsoft Audio Stack enabled.
        /// </summary>
        private static void SpeechRecognitionWithMASEnabled()
        {
            Console.WriteLine("Please choose from the following samples (with Microsoft Audio Stack enabled)");
            var prompt = "Your choice (0: Stop): ";

            Console.WriteLine("1. Speech recognition from default microphone.");
            Console.WriteLine("2. Speech recognition from a microphone with pre-defined microphone array geometry specified.");
            Console.WriteLine("3. Speech recognition from multi-channel file with custom microphone array geometry specified.");
            Console.WriteLine("4. Speech recognition from pull stream with custom set of enhancements enabled.");
            Console.WriteLine("5. Speech recognition from push stream with beamforming angles specified.");

            Console.Write(prompt);

            ConsoleKeyInfo x;
            x = Console.ReadKey();
            Console.WriteLine("");
            switch (x.Key)
            {
                case ConsoleKey.D1:
                    SpeechRecognitionSamples.ContinuousRecognitionFromDefaultMicrophoneWithMASEnabled().Wait();
                    break;
                case ConsoleKey.D2:
                    SpeechRecognitionSamples.RecognitionFromMicrophoneWithMASEnabledAndPresetGeometrySpecified().Wait();
                    break;
                case ConsoleKey.D3:
                    SpeechRecognitionSamples.ContinuousRecognitionFromMultiChannelFileWithMASEnabledAndCustomGeometrySpecified().Wait();
                    break;
                case ConsoleKey.D4:
                    SpeechRecognitionSamples.RecognitionFromPullStreamWithSelectMASEnhancementsEnabled().Wait();
                    break;
                case ConsoleKey.D5:
                    SpeechRecognitionSamples.ContinuousRecognitionFromPushStreamWithMASEnabledAndBeamformingAnglesSpecified().Wait();
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("\nExecution done. " + prompt);
        }

        static void Main(string[] args)
        {

            var prompt = "Your choice (0: Stop): ";

            Console.WriteLine("1. Speech recognition with microphone input.");
            Console.WriteLine("2. Speech recognition in the specified language and using detailed output format.");
            Console.WriteLine("3. Speech continuous recognition with file input.");
            Console.WriteLine("4. Speech recognition using customized model.");
            Console.WriteLine("5. Speech recognition with pull audio stream.");
            Console.WriteLine("6. Speech recognition with push audio stream.");
            Console.WriteLine("7. Speech recognition with keyword spotting.");
            Console.WriteLine("8. Translation with microphone input.");
            Console.WriteLine("9. Translation with file input.");
            Console.WriteLine("A. Translation with audio stream.");
            Console.WriteLine("B. Speech continuous recognition using authorization token.");
            Console.WriteLine("C. Intent recognition with microphone input.");
            Console.WriteLine("D. Intent continuous recognition with file input.");
            Console.WriteLine("E. Intent recognition in the specified language with microphone input.");
            Console.WriteLine("F. Speech synthesis to speaker output.");
            Console.WriteLine("G. Speech synthesis with specified language.");
            Console.WriteLine("H. Speech synthesis with specified voice.");
            Console.WriteLine("I. Speech synthesis to wave file.");
            Console.WriteLine("J. Speech synthesis to mp3 file.");
            Console.WriteLine("K. Speech synthesis to pull audio output stream.");
            Console.WriteLine("L. Speech synthesis to push audio output stream.");
            Console.WriteLine("M. Speech synthesis to result.");
            Console.WriteLine("N. Speech synthesis to audio data stream.");
            Console.WriteLine("O. Speech synthesis events.");
            Console.WriteLine("P. Speech Recognition using Phrase Lists");
            Console.WriteLine("Q. Speech synthesis word boundary event.");
            Console.WriteLine("R. Speech synthesis using authorization token.");
            Console.WriteLine("S. Speech synthesis in server scenario.");
            Console.WriteLine("T. Speech recognition with compressed input pull audio stream.");
            Console.WriteLine("U. Speech recognition with compressed input push audio stream.");
            Console.WriteLine("V. Translation with compressed input push audio stream.");
            Console.WriteLine("W. Keyword recognizer.");
            Console.WriteLine("X. Speech synthesis with source language auto detection.");
            Console.WriteLine("Y. Remote Conversation for an async job.");
            Console.WriteLine("Z. Speech recognition with file input and a switch to secondary region.");
            Console.WriteLine("F1. Speech recognition with language detection enabled samples");
            Console.WriteLine("F2. Standalone language detection samples.");
            Console.WriteLine("F3. Translation with language detection samples.");
            Console.WriteLine("F4. Speech recognition with Microsoft Audio Stack samples.");

            Console.Write(prompt);

            ConsoleKeyInfo x;
            do
            {
                x = Console.ReadKey();
                Console.WriteLine("");
                switch (x.Key)
                {
                    case ConsoleKey.D1:
                        SpeechRecognitionSamples.RecognitionWithMicrophoneAsync().Wait();
                        break;
                    case ConsoleKey.D2:
                        SpeechRecognitionSamples.RecognitionWithLanguageAndDetailedOutputAsync().Wait();
                        break;
                    case ConsoleKey.D3:
                        SpeechRecognitionSamples.ContinuousRecognitionWithFileAsync().Wait();
                        break;
                    case ConsoleKey.D4:
                        SpeechRecognitionSamples.RecognitionUsingCustomizedModelAsync().Wait();
                        break;
                    case ConsoleKey.D5:
                        SpeechRecognitionSamples.RecognitionWithPullAudioStreamAsync().Wait();
                        break;
                    case ConsoleKey.D6:
                        SpeechRecognitionSamples.RecognitionWithPushAudioStreamAsync().Wait();
                        break;
                    case ConsoleKey.D7:
                        SpeechRecognitionSamples.ContinuousRecognitionWithKeywordSpottingAsync().Wait();
                        break;
                    case ConsoleKey.D8:
                        TranslationSamples.TranslationWithMicrophoneAsync().Wait();
                        break;
                    case ConsoleKey.D9:
                        TranslationSamples.TranslationWithFileAsync().Wait();
                        break;
                    case ConsoleKey.A:
                        TranslationSamples.TranslationWithAudioStreamAsync().Wait();
                        break;
                    case ConsoleKey.B:
                        SpeechRecognitionWithTokenSample.ContinuousRecognitionWithAuthorizationTokenAsync().Wait();
                        break;
                    case ConsoleKey.C:
                        IntentRecognitionSamples.RecognitionWithMicrophoneAsync().Wait();
                        break;
                    case ConsoleKey.D:
                        IntentRecognitionSamples.ContinuousRecognitionWithFileAsync().Wait();
                        break;
                    case ConsoleKey.E:
                        IntentRecognitionSamples.RecognitionWithMicrophoneUsingLanguageAsync().Wait();
                        break;
                    case ConsoleKey.F:
                        SpeechSynthesisSamples.SynthesisToSpeakerAsync().Wait();
                        break;
                    case ConsoleKey.G:
                        SpeechSynthesisSamples.SynthesisWithLanguageAsync().Wait();
                        break;
                    case ConsoleKey.H:
                        SpeechSynthesisSamples.SynthesisWithVoiceAsync().Wait();
                        break;
                    case ConsoleKey.I:
                        SpeechSynthesisSamples.SynthesisToWaveFileAsync().Wait();
                        break;
                    case ConsoleKey.J:
                        SpeechSynthesisSamples.SynthesisToMp3FileAsync().Wait();
                        break;
                    case ConsoleKey.K:
                        SpeechSynthesisSamples.SynthesisToPullAudioOutputStreamAsync().Wait();
                        break;
                    case ConsoleKey.L:
                        SpeechSynthesisSamples.SynthesisToPushAudioOutputStreamAsync().Wait();
                        break;
                    case ConsoleKey.M:
                        SpeechSynthesisSamples.SynthesisToResultAsync().Wait();
                        break;
                    case ConsoleKey.N:
                        SpeechSynthesisSamples.SynthesisToAudioDataStreamAsync().Wait();
                        break;
                    case ConsoleKey.O:
                        SpeechSynthesisSamples.SynthesisEventsAsync().Wait();
                        break;
                    case ConsoleKey.P:
                        SpeechRecognitionSamples.ContinuousRecognitionWithFileAndPhraseListsAsync().Wait();
                        break;
                    case ConsoleKey.Q:
                        SpeechSynthesisSamples.SynthesisWordBoundaryEventAsync().Wait();
                        break;
                    case ConsoleKey.R:
                        SpeechSynthesisWithTokenSample.SpeechSynthesisWithAuthorizationTokenAsync().Wait();
                        break;
                    case ConsoleKey.S:
                        SpeechSynthesisServerScenarioSample.SpeechSynthesizeWithPool();
                        break;
                    case ConsoleKey.T:
                        SpeechRecognitionSamples.SpeechRecognitionWithCompressedInputPullStreamAudio().Wait();
                        break;
                    case ConsoleKey.U:
                        SpeechRecognitionSamples.SpeechRecognitionWithCompressedInputPushStreamAudio().Wait();
                        break;
                    case ConsoleKey.V:
                        TranslationSamples.TranslationWithFileCompressedInputAsync().Wait();
                        break;
                    case ConsoleKey.W:
                        SpeechRecognitionSamples.KeywordRecognizer().Wait();
                        break;
                    case ConsoleKey.X:
                        SpeechSynthesisSamples.SynthesisWithAutoDetectSourceLanguageAsync().Wait();
                        break;
                    case ConsoleKey.Y:
                        RemoteConversationSamples.RemoteConversationWithFileAsync().Wait();
                        break;
                    case ConsoleKey.Z:
                        SpeechRecognitionSamples.RecognitionOnceWithFileAsyncSwitchSecondaryRegion().Wait();
                        break;
                    case ConsoleKey.F1:
                        SpeechRecognitionWithLanguageDetectionEnabled();
                        break;
                    case ConsoleKey.F2:
                        LanguageDetectionSamples();
                        break;
                    case ConsoleKey.F3:
                        TranslationWithLanguageDetectionEnabled();
                        break;
                    case ConsoleKey.F4:
                        SpeechRecognitionWithMASEnabled();
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                Console.WriteLine("\nExecution done. " + prompt);
            } while (x.Key != ConsoleKey.D0);
        }
    }
}
