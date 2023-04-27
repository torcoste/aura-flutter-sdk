using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using System;

namespace AuraMobileSDK{
    public class Logging : MonoBehaviour{
        static Logging instance;
        TMPro.TMP_Text logText;
        void Start(){
            instance = this;
            logText = GetComponent<TMPro.TMP_Text>();
        }  
        void LogText(string text){
            if (logText != null)
                logText.text += text + "\n";
        }
        static string ObjectToString(object x){
            if (x == null) return "null";
            if (!(x is string)){
                if (x is KeyValuePair)
                {
                    return $"{ObjectToString(((KeyValuePair<object, object>)x).Key)}: {ObjectToString(((KeyValuePair<object, object>)x).Value)}";
                } else if (x is IEnumerable){
                    StringBuilder stringBuilder = new StringBuilder();
                    bool first = true;
                    if (x is ISet<object> || x is IDictionary<object, object>) stringBuilder.Append('{');
                    else stringBuilder.Append('[');
                    foreach (var t in x as IEnumerable){
                        if (!first)
                            stringBuilder.Append(", ");
                        first = false;
                        stringBuilder.Append(ObjectToString(t));
                    }
                    if (x is ISet<object> || x is IDictionary<object, object>) stringBuilder.Append('}');
                    else stringBuilder.Append(']');
                    return stringBuilder.ToString();
                } else return x.ToString();
            } else return (string) x;
        }
        static string ParamsToString(object[] x){
            if (x == null) return "null";
            if (x.Length == 0) return "";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(ObjectToString(x[0]));
            for (int i = 1; i < x.Length; ++i){
                stringBuilder.Append(' ');
                stringBuilder.Append(ObjectToString(x[i]));
            }
            return stringBuilder.ToString();
        }
        public static void Verbose(params object[] x){
            Debug.Log(ParamsToString(x));
            try{
                instance?.LogText(ParamsToString(x));
            } catch (Exception e){Debug.Log(e.Message);}
        }
        public static void Info(params object[] x){
            Debug.Log(ParamsToString(x));
            try{
                instance?.LogText(ParamsToString(x));
            } catch (Exception e){Debug.Log(e.Message);}
        }
        public static void Error(params object[] x){
            Debug.LogError(ParamsToString(x));
            try{
                instance?.LogText(ParamsToString(x));
            } catch (Exception e){Debug.Log(e.Message);}
        }
        public static void Warning(params object[] x){
            Debug.LogWarning(ParamsToString(x));
            try{
                instance?.LogText(ParamsToString(x));
            } catch (Exception e){Debug.Log(e.Message);}
        }
    }
}