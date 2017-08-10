# Text to Speech sample

## Description

The TextToSpeech bot is a sample that generates synthesized speech on an Azure cloud services and streams the audio to the user in a Skype audio call. For this example, we generate the audio buffers needed by the Real-Time Media Platform using two different text-to-speech (TTS) engines: the local TTS engine from the Azure Virtual Machine running your cloud service, and the Bing Text to Speech engine from the Microsoft Cognitive Services.

This sample is based on the AudiovideoPlayerBot sample from the botFramework (https://github.com/Microsoft/BotBuilder-RealTimeMediaCalling/tree/master/Samples/AudioVideoPlayerBot).

## Test the bot

To add the bot to your account, use this link: https://join.skype.com/bot/93e71a79-73c1-4500-afbd-0f2a0bfee019
Once added, establish an audio call and you will hear a short sentence generated by the bot by the two TTS engines.

## Deploy the bot sample
Prerequisites and instructions for deploying are [here](https://docs.microsoft.com/en-us/bot-framework/dotnet/bot-builder-dotnet-real-time-deploy-visual-studio). Update the configuration before deploying the sample per the instructions below.

## Obtain a Bing Speech API key
As part of our sample we use the [Bing Text to Speech API](https://docs.microsoft.com/en-us/azure/cognitive-services/speech/api-reference-rest/bingvoiceoutput) to generate the audio, so you need to add a Bing Speech API endpoint to your Azure subscription and take note of the API key (you will find it under “Resource Management -> Keys” on the Azure Portal).

## Update configuration

-	In app.config of the WorkerRole, replace *$BotHandle$*, *$MicrosoftAppId$* and *$BotSecret$* with values obtained during bot registration.

```xml
<appSettings>
    <!-- update these with your BotId, Microsoft App Id and your Microsoft App Password-->
    <add key="BotId" value="$BotHandle$"/>
    <add key="MicrosoftAppId" value="$MicrosoftAppId$"/>
    <add key="MicrosoftAppPassword" value="$BotSecret$"/>
 </appSettings>
```

-	Substitute the *$CertificateThumbprint$* in service configuration (ServiceConfiguration.Cloud.cscfg file) with appropriate values in the config.
```xml
<Setting name="DefaultCertificate" value="$CertificateThumbprint$" />
```

-  Replace the API Key from your Bing Speech API endpoint 
```xml
<Setting name="Skype.Bots.Speech.Subscription" value="$BingSpeechAPIKey$"/>
```

## How it works:

The bot is initialized to use only the audio channel in PCM 16 format:

```csharp
// create the audio socket
_audioSocket = new AudioSocket(
    new AudioSocketSettings
    {
        StreamDirections = StreamDirection.Sendrecv,
        SupportedAudioFormat = AudioFormat.Pcm16K,
        CallId = correlationId
    });
    
// subscribe to audio socket events
_audioSocket.AudioSendStatusChanged += OnAudioSendStatusChanged;
                
// create the mediaconfiguration with only audio channel
MediaConfiguration = MediaPlatform.CreateMediaConfiguration(_audioSocket);
```


Both the local TTS engine ([TTSEngineLocal.cs](https://github.com/Microsoft/skype-dev-bots/tree/master/Samples/Csharp/RealtimeMedia/TextToSpeech/FrontEnd/Tts/TtsEngineLocal.cs)) and the Bing Text to Speech engine ([TTSEngineService](https://github.com/Microsoft/skype-dev-bots/tree/master/Samples/Csharp/RealtimeMedia/TextToSpeech/FrontEnd/Tts/TtsEngineService.cs)) generate an audio stream containing the synthesized audio. The stream is then converted into 20ms buffers needed by the `AudioVideoFramePlayer` to start the playback, and this is done in the `MediaSession` class:

```csharp
// create 20ms buffers from the input stream
while (stream.Read(bytesToRead, 0, bytesToRead.Length) >= bufferSize)change
{
    IntPtr unmanagedBuffer = Marshal.AllocHGlobal(bufferSize);
    Marshal.Copy(bytesToRead, 0, unmanagedBuffer, bufferSize);
                
    // move the reference time by 20ms (there are 10K ticks in 1 ms)
    referenceTimeTick += 20 * 10000; 

    // create the audio buffer and add it to the list
    var audioBuffer = new AudioSendBuffer(
        unmanagedBuffer, 
        bufferSize,   
        AudioFormat.Pcm16K, 
        referenceTimeTick);
    audioBuffers.Add(audioBuffer);
}
```