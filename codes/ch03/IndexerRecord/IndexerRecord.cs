using System;
using System.Collections.Generic;

class IndexerRecord
{
    private string[] data = new string[6];
    private string[] keys = {
        "Author", "Publisher", "Title",
        "Subject", "ISBN", "Comments"
        };
    public string this[int idx]
    {
        set{
            if (idx >= 0 && idx < data.Length)
                data[idx] = value;
        }
        get{
            if (idx >= 0 && idx < data.Length)
                return data[idx];
            return null;
        }
    }
    public string this[string key]
    {
        set{
            int idx = FindKey(key);
            this[idx] = value;
        }
        get{
            return this[FindKey(key)];
        }
    }
    private int FindKey(string key) {
        for (int i = 0; i < keys.Length; i++)
            if (keys[i] == key) return i;
        return -1;
    }
    static void Main() {
        IndexerRecord record = new IndexerRecord();
        record[0] = "马克-吐温";
        record[1] = "Crox出版公司";
        record["Title"] = "汤姆-索亚历险记";
        Console.WriteLine(record[2]);
        Console.WriteLine(record["Author"]);
        Console.WriteLine(record["Publisher"]);
    }
}


