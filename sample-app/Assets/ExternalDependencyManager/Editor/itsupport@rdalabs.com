itsupport@rdalabs.com
Cloud980!




/Applications/Unity/Hub/Editor/2020.3.20f1/Unity.app/Contents/MacOS/Unity -quit -batchmode -projectPath '/Users/prakharsrivastava/Desktop/Trackier/My project' -executeMethod Script.PerformBuild

/Users/prakharsrivastava/Desktop/Trackier/My project

/Users/prakharsrivastava/Desktop/Trackier/My project/Assets/Script



/Users/prakharsrivastava/Desktop/Trackier/unity-sdk



/Applications/Unity/Hub/Editor/2020.3.20f1/Unity.app/Contents/MacOS/Unity -gvh_disable \
      -batchmode \
      -importPackage external-dependency-manager-1.2.167.unitypackage \
      -projectPath /Users/prakharsrivastava/Desktop/Trackier/unity-sdk \
      -exportPackage Assets TrackierUnitySdk.unitypackage \
      -quit