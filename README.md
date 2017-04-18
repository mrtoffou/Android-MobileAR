# MobileAR
This project was made with John Lam and King Lo, students at Georgia Gwinnett College to present our app in STaRS create event and leadership Gwinnett on 4/11/17 and 4/12/17.

## What is this
This app is developed by using Unity3D engine and Vuforia and deployed to an android phone to view augmented reality.

## How
By registering any image through Vuforia developer's portal(free registration with some limitations) we are able to download a unity package and import it to Unity. Before registering you will need to create an account, create an image database, and store images onto it. You will need a database license key to input into Unity to register these images.
This project was developed using Vuforia's up-to-date SDK as of 4/12/17 and Unity version 5.6.0f3 (64 bit).
If you have ever built any unity3d applications the process is really simple.
* Take imageTarget prefab from vuforia's SDK and drag it to scene.
* Take ARCamera and drag to scene, delete MainCamera object.
* Click on ARCamera settings and input license key and import the image target database you downloaded earlier when packaging.
* Select database and under each imageTarget prefab select the correct database and an image.
* Start building 3D objects as the children for each imageTarget and deploy to android.

Tutorial at [https://library.vuforia.com/tutorials](https://library.vuforia.com/tutorials).

<img src="/mobile_ar/mobile_ar_planets_00.PNG" width="400"/>
<img src="/mobile_ar/mobile_ar_planets_01.PNG" width="400"/>
<img src="/mobile_ar/mobile_ar_maze_00.PNG" width="400" height="400"/>
<img src="/mobile_ar/mobile_ar_skeleton_00.PNG" width="400"/>
<img src="/mobile_ar/mobile_ar_office_00.PNG" width="400"/>
