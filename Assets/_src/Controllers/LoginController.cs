using PoliticalSimulatorCore.CustomExceptions;
using PoliticalSimulatorCore.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class LoginController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadProfile()
    {
        //get the text from the input and feed it to the other method
        GameObject inputFieldGo =  GameObject.Find("InputField");
        if(inputFieldGo != null)
        {
            InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
            if(inputFieldCo != null)
            {
                loadProfile(inputFieldCo.text);
                SceneController.Instance.LoadLevel("Menu");
            }
        }

    }

    public void RegisterProfile()
    {
        //get the text from the input and feed it to the other method
        GameObject inputFieldGo = GameObject.Find("InputField");
        if (inputFieldGo != null)
        {
            InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
            if (inputFieldCo != null)
            {
                createProfile(inputFieldCo.text);
                SceneController.Instance.LoadLevel("Menu");
            }
        }

    }

    /**
	     * Load the profile with the given string. Throw a ProfileNotFoundException 
	     * if the profile file could not be found.
	     * @param profileToLoad The profile to load
	     * @return The loaded UserProfile
	     * @throws ProfileNotFoundException
	     * @throws ClassNotFoundException
	     */
    private static UserProfile loadProfile(string profileToLoad)
    {
        UserProfile profile;
        //load profile.dat
        try
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("Profiles\\" + profileToLoad + ".dat", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                profile = (UserProfile)formatter.Deserialize(stream);
            }

            return profile;

        }
        catch (IOException e)
        {
            throw new ProfileNotFoundException(profileToLoad, DateTime.Now);
        }
    }

    /**
     * Save the given profile.
     * @param profileToSave The UserProfile to save to a file
     * @return true if save was succesful, false if not
     */
    private static bool saveProfile(UserProfile profileToSave)
    {
        //create the folder if it does not exist already
        if (!Directory.Exists("Profiles"))
        {
            Directory.CreateDirectory("Profiles");
        }

        try
        {
            using (Stream stream = new FileStream("Profiles\\" + profileToSave.Name + ".dat", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, profileToSave);
            }
        }
        catch (IOException ex)
        {
            //Logit
            return false;
        }

        return true;
    }

    /**
     * Create a UserProfile with the given String
     * @param name Name of UserProfile to create
     */
    private static void createProfile(String name)
    {
        UserProfile newUser = new UserProfile(name);
        MainController.CurrentUserProfile = newUser;
        saveProfile(newUser);
    }

    /**
     * Delete a UserProfile with the given String
     * @param profileToDelete Name of UserProfile to delete
     */
    private static void DeleteProfile(String profileToDelete)
    {
        if (File.Exists("Profiles\\" + profileToDelete + ".dat"))
        {
            File.Delete("Profiles\\" + profileToDelete + ".dat");
        }
    }

    /**
     * Save the active profile.
     */
    private static void saveActiveProfile()
    {
        saveProfile(MainController.CurrentUserProfile);
    }
}
