# Unite Camera Control
A small Unity app for practicing camera controls, originally developed for Unite UMN

# Setup

## Getting the source code

This project uses Git Large File Storage (LFS) to store assets. You can find and install LFS [here](https://git-lfs.github.com/).

## Project Setup

After you have cloned the repository to a local directory, you can add it in the Unity Hub using `Add -> Browse to directory`. If you don't have the correct unity version installed it will likely build and play with any recent version.

The first time you open or build the project you can expect to wait a couple minutes while Unity imports the project or compiles assets. Future startup and build times should see significant speed ups.

After Unity has loaded the project, open the scene located in the `Scenes` folder.

After opening the scene you should be prompted to import TMP Essentials. Select `Import TMP Essentials` to have the package manager download the necessary assets. You do not need to `Import TMP Examples & Extras`.

At this point you can play the project in the editor to ensure everything is working as intended.

## Building

To build an APK, select `File -> Build Settings` and change the target platform to `Android`. Click `Switch Platform` and Unity will take a moment to configure things for the new build target. The default settings should be fine and you can click `Build` and pick an output directory to save the APK to.

# Video transcoding

The most notable wait time when opening the project is the Video Transcoding step. This process ensures that the video will work on the target build platforms, but if you're just quickly testing things out the video might work find without it. The important thing is that the video is transcoded before any distribution builds so you can skip transcoding in other cases.