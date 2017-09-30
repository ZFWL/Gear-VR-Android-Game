# VR Sword Fighting Game

This game(made in Unity) you're a human-like Android on a quest through a procedurally generated Apocalyptic City fighting enemies with a sword that looks very similar to a lightsaber. This game runs on the Samsung Gear VR headset and Perception Neuron Motion Capture Suit. This project was a group effort made by 22 computer science students along with 4 game design students at the California State University, Monterey Bay in the CST 495 Special Topics class. 
![unity](https://user-images.githubusercontent.com/18353476/29190917-b09be474-7dd0-11e7-9ada-b68d15f26d54.gif)

# City and Building Design
![building textures closeup](https://user-images.githubusercontent.com/18353476/28497537-b679d07c-6f3e-11e7-9dca-4825d375939a.PNG)

# Upcoming Levels Design
A new level is coming(Late 2017/Early 2018). It will take you out of the City limits and onto an abandoned Farm where you will face new enemies and obstacles to continue your quest. Working on an Alien Planet map that has an abandoned military base.

Farm Level Map
![the farm](https://user-images.githubusercontent.com/18353476/30253492-42d3a5b6-963b-11e7-879a-6bc96ce6e624.png)

Space Level Map
![space map](https://user-images.githubusercontent.com/18353476/30890957-ef755c32-a2e4-11e7-8168-8bf67e25bd0e.gif)

# Neuron Motion Capture Suit
An important part of this project was the integration of the Perception Neuron Motion Capture suit. It was received in January 2016 when the suit was still in the Beta development phase.

<p align="center">
  <img alt="[axis neuron" src="https://user-images.githubusercontent.com/18353476/27672565-a9dd312a-5c50-11e7-974d-5609f9cd3b0c.png">
</p>

<p align="center">
  <img alt="[perceptionneuron" src="https://user-images.githubusercontent.com/18353476/27672571-b08bed9a-5c50-11e7-9daf-cff544e88a36.jpg">
</p>

# Samsung Gear VR Headset
[Mobile Development with Unity and Unreal](https://developer.oculus.com/documentation/mobilesdk/latest/concepts/mobile-game-engine/#mobile-game-engine)

[Preparing for Mobile Development](https://developer.oculus.com/documentation/unity/latest/concepts/unity-mobileprep/)

[Gear VR Device Setup](https://developer.oculus.com/documentation/mobilesdk/latest/concepts/mobile-device-setup/)

[Building Gear VR apps in Unity](https://developer.oculus.com/documentation/unity/latest/concepts/unity-build-android/#unity-build-android-store)
![gear-vr](https://user-images.githubusercontent.com/18353476/28398251-27e2fe5e-6cbb-11e7-9d5a-7ecd3d154f4f.jpg)


# Getting Started with Android NDK
The [Native Development Kit (NDK)](https://developer.android.com/ndk/guides/index.html) is a set of tools that allows you to use C and C++ code with Android, and provides platform libraries you can use to manage native activities and access physical device components, such as sensors and touch input. The NDK may not be appropriate for most novice Android programmers who need to use only Java code and framework APIs to develop their apps. However, the NDK can be useful for cases in which you need to do one or more of the following:

  Squeeze extra performance out of a device to achieve low latency or run computationally intensive applications, such as games or  physics simulations.

  Reuse your own or other developers' C or C++ libraries.

Using [Android Studio](https://developer.android.com/studio/index.html) 2.2 and higher, you can use the NDK to compile C and C++ code into a native library and package it into your APK using Gradle, the IDE's integrated build system. Your Java code can then call functions in your native library through the Java Native Interface (JNI) framework. To learn more about Gradle and the Android build system, read Configure Your Build.

# Vulkan Support 
Vulkan is a new generation graphics and compute API that provides high-efficiency, cross-platform access to modern GPUs in both PCs and on mobile platforms. The Android Nougat version 7.0 from Google brings official support for the Vulkan API.The main benefit of Vulkan over older mobile rendering APIs such as OpenGL ES 3.x is speed. Vulkan is designed to take advantage of multiple CPU cores by allowing the application to build command lists in multiple threads in parallel. This allows the application to take advantage of all of the CPU cores on the device, improving performance.

To enable Vulkan support, open “Player Settings”, go to the “Other Settings” pane and clear the “Auto Graphics API” checkbox. You are presented with an ordered list of graphics APIs to choose from. If Vulkan is not on that list, click the ‘+’ sign at the bottom of the list to add it. Then drag Vulkan to be the first item on the list so that it’ll be used whenever supported, and you’re done! All your existing shaders will get translated to Vulkan SPIR-V.
![vulkan](https://user-images.githubusercontent.com/18353476/28993201-7543d586-7965-11e7-8e9c-f93b7079e2bf.PNG)

# Links for Hardware used below:

Samsung Gear VR Headset https://www.oculus.com/gear-vr/

Perception Neuron Motion Capture Suit  https://neuronmocap.com/products-fullwidth?field_category_value=PN
