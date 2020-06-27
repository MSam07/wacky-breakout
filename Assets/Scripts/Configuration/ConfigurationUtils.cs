using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configurationData;

    #region Properties
        
    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public static float BallImpulseForce
    {
        get { return configurationData.BallImpulseForce; }    
    }

    /// <summary>
    /// Gets the ball life time in seconds
    /// </summary>
    /// <value>ball life time</value>
    public static float BallLifeTime
    {
        get { return configurationData.BallLifeTime; }
    }

    /// <summary>
    /// Gets the min spawn time in seconds
    /// </summary>
    /// <value>min spawn time in second</value>
    public static float MinSpawnSeconds
    {
        get {return configurationData.MinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the max spawn time in seconds
    /// </summary>
    /// <value>max spawn time in second</value>
    public static float MaxSpawnSeconds
    {
        get {return configurationData.MaxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the standart block points
    /// </summary>
    /// <value>points</value>
    public static int StandartBlockPoints
    {
        get {return configurationData.StandartBlockPoints; }
    }

    /// <summary>
    /// Gets the bonus block points
    /// </summary>
    /// <value>points</value>
    public static int BonusBlockPoints
    {
        get {return configurationData.BonusBlockPoints; }
    }

    /// <summary>
    /// Gets the pickup block points
    /// </summary>
    /// <value>points</value>
    public static int PickupBlockPoints
    {
        get {return configurationData.PickupBlockPoints; }
    }

    /// <summary>
    /// Gets the standart block probability
    /// </summary>
    /// <value>probability</value>
    public static float StandartBlockProbability
    {
        get {return configurationData.StandartBlockProbability; }
    }

    /// <summary>
    /// Gets the bonus block probability
    /// </summary>
    /// <value>probability</value>
    public static float BonusBlockProbability
    {
        get {return configurationData.BonusBlockProbability; }
    }

    /// <summary>
    /// Gets the pickup block probability
    /// </summary>
    /// <value>probability</value>
    public static float PickupBlockProbability
    {
        get {return configurationData.PickupBlockProbability; }
    }


    /// <summary>
    /// Gets the number of balls in the game
    /// </summary>
    /// <value>number of balls</value>
    public static int BallsPerGame
    {
        get {return configurationData.BallsPerGame; }
    }


    /// <summary>
    /// Gets the freezer effect duration in seconds
    /// </summary>
    /// <value>freezer effect duration in seconds</value>
    public static float FreezerEffectDuration
    {
        get {return configurationData.FreezerEffectDuration; }
    }


    /// <summary>
    /// Gets speedup effect duration in seconds
    /// </summary>
    /// <value>speedup effect duration in seconds</value>
    public static float SpeedupEffectDuration
    {
        get {return configurationData.SpeedupEffectDuration; }
    }

    /// <summary>
    /// Gets the speedup effect value
    /// </summary>
    /// <value>speedup value</value>
    public static float SpeedupEffectValue
    {
        get {return configurationData.SpeedupEffectValue; }
    }


    #endregion
    
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }

}
