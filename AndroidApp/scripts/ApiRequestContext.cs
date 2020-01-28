using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
// using System.Threading.Tasks;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ApiRequestcontext {
    public string subAddress{get; private set;}
    public Action<ApiResponseContext> resultCallback;
    public List<KeyValuePair<string, System.Object>> data = new List<KeyValuePair<string, System.Object>> ();
    public List<KeyValuePair<string, string>> files = new List<KeyValuePair<string, string>> ();
    public RequestMethod requestMethod{get; private set;}

    public ApiRequestcontext () {
        changeRequestMethod(RequestMethods.post);
    }

    public void changeSubAddress (string subAddress) {
        this.subAddress = subAddress;
    }

    public void addData (string key, System.Object value) {
        this.data.Add (
            new KeyValuePair<string, System.Object> (key, value)
        );
    }
    public void addFile (string key, string value) {
        files.Add (
            new KeyValuePair<string, string> (key, value)
        );
    }

    public string getAllDataAsString () {
        StringBuilder builder = new StringBuilder ();
        foreach (var item in data) {
            builder.Append (item.Key);
            builder.Append ("=");
            builder.Append (item.Value);
            builder.Append ("&");
        }
        builder.Remove (builder.Length - 1, 1);
        return builder.ToString ();
    }
    public string getData (string key) {
        foreach (var item in data) {
            if (item.Key == key) {
                return item.Value.ToString();
            }
        }
        return string.Empty;
    }

    public void changeRequestMethod(RequestMethod requestType){
        this.requestMethod = requestType;
    }

    public static ApiRequestcontext fromJson (string json) {
        // log (json);
        // SimpleJson.JsonObject jobj = SimpleJson.SimpleJson.DeserializeObject<JsonObject> (json);
        // ApiRequestcontext context = new ApiRequestcontext ();
        // foreach (var item in jobj.Keys) {
        //     context.addData (item, jobj[item].ToString ());
        // }

        JObject jobj = JObject.Parse (json);
        ApiRequestcontext context = new ApiRequestcontext ();
        foreach (var item in jobj.Properties ()) {
            context.addData (item.Name, jobj.GetValue (item.Name).ToString ());
        }
        return context;
    }
}