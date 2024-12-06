using UnityEngine;
using UnityEditor;

namespace SuperSecretNamespace
{
    public static class EntitasSecretSettingsProvider
    {
        private const string k_SecretSettingPath = "Preferences/Secret Setting";
        private const string k_FullSettingText = "I copied the repo";

        [SettingsProvider]
        public static SettingsProvider CreateSecretSettingProvider()
        {
            var provider = new SettingsProvider(k_SecretSettingPath, SettingsScope.Project)
            {
                guiHandler = (searchContext) =>
                {
                    EditorGUI.BeginChangeCheck();
                    
                    bool copiedRepo = EditorPrefs.GetBool("EntitasSecretSetting", true);
                    
                    // Create a Rect for the toggle to allow tooltip
                    Rect toggleRect = EditorGUILayout.GetControlRect();
                    
                    // Draw the toggle with the full text tooltip
                    copiedRepo = EditorGUI.Toggle(toggleRect, 
                        new GUIContent(
                            k_FullSettingText, 
                            k_FullSettingText
                        ), 
                        copiedRepo);
                    
                    if (EditorGUI.EndChangeCheck())
                    {
                        EditorPrefs.SetBool("EntitasSecretSetting", copiedRepo);
                    }
                },

                keywords = new[] { "Entitas", "Secret", "Setting" }
            };

            return provider;
        }
    }
}