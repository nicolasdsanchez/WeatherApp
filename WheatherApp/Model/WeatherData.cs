﻿using System;
using System.Collections.Generic;

public class WeatherData
{
    public double lat { get; set; }
    public double lon { get; set; }
    public string timezone { get; set; }
    public int timezone_offset { get; set; }
    public List<Data> data { get; set; }
}

public class Data
{
    public long dt { get; set; }
    public long sunrise { get; set; }
    public long sunset { get; set; }
    public double temp { get; set; }
    public double feels_like { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set; }
    public double dew_point { get; set; }
    public double uvi { get; set; }
    public int clouds { get; set; }
    public int visibility { get; set; }
    public double wind_speed { get; set; }
    public int wind_deg { get; set; }
    public List<Weather> weather { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}
