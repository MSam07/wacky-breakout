using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    float paddleMoveUnitsPerSecond = 10;
    float ballImpulseForce = 200;
    float ballLifeTime = 10;
    float minSpawnSeconds = 5;
    float maxSpawnSeconds = 10;
    int standartBlockPoints = 1;
    int bonusBlockPoints = 2;
    int pickupBlockPoints = 5;
    float standartBlockProbability = 73;
    float bonusBlockProbability = 22;
    float pickupBlockProbability = 5;
    int ballsPerGame = 5;
    float freezerEffectDuration = 2;
    float speedupEffectDuration = 2;
    float speedupEffectValue = 2;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }

    /// <summary>
    /// Gets the ball life time in seconds
    /// </summary>
    /// <value>ball life time in second</value>
    public float BallLifeTime
    {
        get { return ballLifeTime; }
    }

    /// <summary>
    /// Gets the min spawn time in seconds
    /// </summary>
    /// <value>min spawn time in second</value>
    public float MinSpawnSeconds
    {
        get { return minSpawnSeconds; }
    }

    /// <summary>
    /// Gets the max spawn time in seconds
    /// </summary>
    /// <value>max ball life time in second</value>
    public float MaxSpawnSeconds
    {
        get { return maxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the standart block points
    /// </summary>
    /// <value>points</value>
    public int StandartBlockPoints
    {
        get { return standartBlockPoints;  }
    }

    /// <summary>
    /// Gets the bonus block points
    /// </summary>
    /// <value>points</value>
    public int BonusBlockPoints
    {
        get { return bonusBlockPoints; }
    }

    /// <summary>
    /// Gets the pickup block points
    /// </summary>
    /// <value>points</value>
    public int PickupBlockPoints
    {
        get { return pickupBlockPoints; }
    }

    /// <summary>
    /// Gets the standart block probability
    /// </summary>
    /// <value>probability</value>
    public float StandartBlockProbability
    {
        get {return standartBlockProbability; }
    }

    /// <summary>
    /// Gets the bonus block probability
    /// </summary>
    /// <value>probability</value>
    public float BonusBlockProbability
    {
        get {return bonusBlockProbability; }
    }

    /// <summary>
    /// Gets the pickup block probability
    /// </summary>
    /// <value>probability</value>
    public float PickupBlockProbability
    {
        get {return pickupBlockProbability; }
    }

    /// <summary>
    /// Gets the number of balls in the game
    /// </summary>
    /// <value>number of balls</value>
    public int BallsPerGame
    {
        get {return ballsPerGame; }
    }


    /// <summary>
    /// Gets the freezer effect duration in seconds
    /// </summary>
    /// <value>freezer effect duration in seconds</value>
    public float FreezerEffectDuration
    {
        get {return freezerEffectDuration; }
    }

    /// <summary>
    /// Gets speedup effect duration in seconds
    /// </summary>
    /// <value>speedup effect duration in seconds</value>
    public float SpeedupEffectDuration
    {
        get {return speedupEffectDuration; }
    }

    /// <summary>
    /// Gets the speedup effect value
    /// </summary>
    /// <value>speedup value</value>
    public float SpeedupEffectValue
    {
        get {return speedupEffectValue; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
            string values = input.ReadLine();

            // set configuration data fields
            SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
        }
        finally
        {               
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    void SetConfigurationDataFields(string csvValues)
    {
        // the code below assumes we know the order in which the
        // values appear in the string. We could do something more
        // complicated with the names and values, but that's not
        // necessary here
        string[] values = csvValues.Split(','); 
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifeTime = float.Parse(values[2]);
        minSpawnSeconds = float.Parse(values[3]);
        maxSpawnSeconds = float.Parse(values[4]);
        standartBlockPoints = int.Parse(values[5]);
        bonusBlockPoints = int.Parse(values[6]);
        pickupBlockPoints = int.Parse(values[7]);
        standartBlockProbability = float.Parse(values[8]);
        bonusBlockProbability = float.Parse(values[9]);
        pickupBlockProbability = float.Parse(values[10]);
        ballsPerGame = int.Parse(values[10]);
        freezerEffectDuration = float.Parse(values[11]);
        speedupEffectDuration = float.Parse(values[12]);
        speedupEffectValue = float.Parse(values[13]);
    }

    #endregion
}
