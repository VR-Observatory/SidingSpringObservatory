# 2021-S1-2-C | Virtual Reality Rendition of the DREAMS Telescope | ANU Techlauncher

**For more info and documentation, see our [landing page](https://sites.google.com/view/2021-s2-techlauncher-dreams/home)**

### Overview
We aim to create a virtual version (VR) of the telescope for outreach and educational purposes.  The experience will run on the Oculus Quest VR headset, where users will be able to examine a model of the telescope itself.  Basic movement and interactions will be a part of the experience.

We will be reworking existing CAD models of the telescope to be compatible and optimized for the Unity game engine.  With the assistance of 3D modelling software (such as Blender), we will be creating a rendition of the building and landscape surrounding the telescope itself.  We aim to implement basic interactions and add dynamic elements to the scene (telescope moving on each axis, day/night cycle, etc.).  We will be targeting 60 frames per second for the Oculus Quest.

Our project will be valuable to educational institions, engineers and researchers interested in astronomy.  The VR experience will assist with outreach and PR for the telescope.  We also aim to release our project to the public via the Unity asset store and Oculus.

The DREAMS telescope is the next in a series of telescopes being brought to Virtual Reality.  A previous Techlauncher group worked on the Giant Magellan Telescope (GMT) in 2020, and we will be using some of thier source code as a starting point.

### Links
[Project Landing Page - Information About our Project](https://sites.google.com/view/2021-s2-techlauncher-dreams/home)

[Google Drive - Documentation & Assets](https://drive.google.com/drive/folders/1rxuu53fC7sdDQ-8IuXaFRbKkWeSXq4gD?usp=sharing)

[Trello - Kanban Style Development Board](https://trello.com/b/t7usLZgQ/vr-dreams-telescope)

[2021 Semester 1 Project Landing Page (old) - Information About our Project](https://sites.google.com/view/2021-s1-techlauncher-dreams/home)

### Document Description
All main Unity files is stroed in 2021_s1_anu_dreams_techlauncher/DREAMS_Unity/DREAMS/Assets, this folder mainly includes:

	- Animation (All animation and animator for objects)
	- Materials (All materials and texture including images used for material)
	- NonPrefabsResourses (All resourses which not mainly prefabs but might include prefabs inside, for example Oculus SDK)
	- Prefabs (All models and object resourses including Terrain, furniture, Telescope...)
	- Resources (NOT INCLUDE object resources, INCLUDE Platform Setting)
	- Scenes (All demo scenes and main scene)
	- Scripts (Most coding files used in scene, other files can be found in NonPrefabsResources)
	- TextMesh Pro (All files for Text Setting)
	- XR (All XR settings)