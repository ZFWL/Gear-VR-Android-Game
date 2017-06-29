using UnityEngine;
using System.Collections.Generic;

public class TTSDemoSceneManager : MonoBehaviour
{
    private bool _initializeError = false;
    private string _inputText = "\n\n\n\n";
    private int _speechId = 0;
    private float _pitch = 1f, _speechRate = 1f;
    private int _selectedLocale = 0;
    private string[] _localeStrings;
    public SpeechToText stringSource;

    // Use this for initialization
    void Start()
    {
        // Screen.sleepTimeout = SleepTimeout.NeverSleep;
        TTSManager.Initialize(transform.name, "OnTTSInit");


        if (TTSManager.IsInitialized())
        {
            if (_localeStrings != null && _localeStrings.Length > 0)
            {

                //_selectedLocale = GUILayout.SelectionGrid(_selectedLocale, _localeStrings, 3);
                TTSManager.SetLanguage(TTSManager.GetAvailableLanguages()[_selectedLocale]);
                TTSManager.SetLanguage(TTSManager.ENGLISH);
            }
           

          //  _pitch = TTSManager.SetPitch(_pitch, 0f, 2f);

          //  _speechRate = TTSManager.SetSpeechRate(_speechRate, 0f, 2f);
        }
    }

    /*
    void OnGUI()
    {
      
        if (TTSManager.IsInitialized())
        {
            _inputText = stringSource.getWords ();

                // Speak
                TTSManager.Speak(_inputText, true, TTSManager.STREAM.Music, 1f, 0f, transform.name, "OnSpeechCompleted", "speech_" + (++_speechId));

              //Add to Queue
                TTSManager.Speak(_inputText, true, TTSManager.STREAM.Music, 1f, 0f, transform.name, "OnSpeechCompleted", "speech_" + (++_speechId));

             //Synthesize to SDCard root folder
                TTSManager.SynthesizeToFile(_inputText, "/mnt/sdcard/speech_" + (++_speechId) + ".wav", transform.name, "OnSynthesizeCompleted", "speech_" + (++_speechId));

            //Stop
                TTSManager.Stop();

         

            if (_localeStrings != null && _localeStrings.Length > 0)
            {
                _selectedLocale = TTSManager.SetLanguage(TTSManager.ENGLISH,_selectedLocale, _localeStrings, 3);
            } 

          

            _pitch = TTSManager.SetPitch(_pitch, 0f, 2f);
            
            _speechRate = TTSManager.SetSpeechRate(_speechRate, 0f, 2f);
            
          
        } 

    }*/

    void OnDestroy()
    {
        TTSManager.Shutdown();
    }

    void OnTTSInit(string message)
    {
        int response = int.Parse(message);

        switch (response)
        {
            case TTSManager.SUCCESS:

                List<TTSManager.Locale> l = TTSManager.GetAvailableLanguages();
                _localeStrings = new string[l.Count];
                for (int i = 0; i < _localeStrings.Length; ++i)
                    _localeStrings[i] = l[i].Name;

                break;
            case TTSManager.ERROR:
                _initializeError = true;
                break;
        }
    }

    void OnSpeechCompleted(string id)
    {
        Debug.Log("Speech '" + id + "' is complete.");
    }

    void OnSynthesizeCompleted(string id)
    {
        Debug.Log("Synthesize of speech '" + id + "' is complete.");
    }

    public void Speak(string words)
    {


        TTSManager.Speak(words, true, TTSManager.STREAM.Music, 1f, 0f, transform.name, "OnSpeechCompleted", "speech_" + (++_speechId));

    }
}
