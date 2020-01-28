using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class ApiResponseContext
{
    public ApiResponseContext(bool success, string value)
    {
        this.success = success;
        this.response = value;
        parse();
    }
    public ApiResponseContext()
    {
        parse();
    }

    public bool success;
    public string response;

    private JObject ParsedObject;

    public JObject parse()
    {
        if (ParsedObject == null)
        {
            try
            {
                JToken jtoken = JToken.Parse(response);
                ParsedObject = (JObject)jtoken.First;
            }
            catch (InvalidCastException e)
            {
                ParsedObject = JObject.Parse(response);
            }
            catch(Exception e){
                success = false;
                ParsedObject = new JObject();
            }

        }
        return ParsedObject;
    }

    public Dictionary<string, string> getExtractedData()
    {
        Dictionary<string, string> data = new Dictionary<string, string>();

        foreach (var item in ParsedObject.Properties())
        {
            data.Add(item.Name, ParsedObject.GetValue(item.Name).ToString());
        }
        return data;
    }

    public bool tryGetData<T>(string key, out T value, T defaultValue)
    {
        try
        {
            JToken output;
            bool found = ParsedObject.TryGetValue(key, out output);
            if (found)
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;
                value = (T)output.ToObject(typeof(T),serializer);
                return true;
            }
            value = defaultValue;
            return false;
        }
        catch (Exception e)
        {
            value = defaultValue;
            UnityEngine.Debug.Log(e.Message);
            return false;
        }
    }

}
