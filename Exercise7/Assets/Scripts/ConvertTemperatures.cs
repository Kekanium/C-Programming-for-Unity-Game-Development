using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for converting temperatures
/// </summary>
public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int startFahrenheit, processCelsius, finalFahrenheit;
        //int part
        startFahrenheit = 0;
        processCelsius = (startFahrenheit - 32) / 9 * 5;
        finalFahrenheit = processCelsius * 9 / 5 + 32;
        print("Int: Start Fahrenheit: " + startFahrenheit + " Process Celsius: " + processCelsius + " End Fahrenheit: " + finalFahrenheit);

        startFahrenheit = 32;
        processCelsius = (startFahrenheit - 32) / 9 * 5;
        finalFahrenheit = processCelsius * 9 / 5 + 32;
        print("Int: Start Fahrenheit: " + startFahrenheit + " Process Celsius: " + processCelsius + " End Fahrenheit: " + finalFahrenheit);

        startFahrenheit = 212;
        processCelsius = (startFahrenheit - 32) / 9 * 5;
        finalFahrenheit = processCelsius * 9 / 5 + 32;
        print("Int: Start Fahrenheit: " + startFahrenheit + " Process Celsius: " + processCelsius + " End Fahrenheit: " + finalFahrenheit);
        //float part
        float startFahrenheitf, processCelsiusf, finalFahrenheitf;

        startFahrenheitf = 0;
        processCelsiusf = (startFahrenheitf - 32) / 9 * 5;
        finalFahrenheitf = processCelsiusf * 9 / 5 + 32;
        print("Float: Start Fahrenheit: " + startFahrenheitf + " Process Celsius: " + processCelsiusf + " End Fahrenheit: " + finalFahrenheitf);
        //double part
        double startFahrenheitd, processCelsiusd, finalFahrenheitd;

        startFahrenheitd = 0;
        processCelsiusd = (startFahrenheitd - 32) / 9 * 5;
        finalFahrenheitd = processCelsiusd * 9 / 5 + 32;
        print("Double: Start Fahrenheit: " + startFahrenheitd + " Process Celsius: " + processCelsiusd + " End Fahrenheit: " + finalFahrenheitd);
    }
}
