# Twitter VR Demo
This project is aimed to create a virtual representation of a VR app with a 3D interface to challenge the method of interaction and search in a Virtual environment.

There are two variations of the same project released:

1. A desktop app environment
2. A virtual app environment

Please keep in mind that I am strictly a developer and not a graphic designer. If you would like to contribute to the looks and feel of this environment please send me a P.M. and possibly I could proceed with graphics and looks improvement for this project.

## Introduction
In the world which is filled with data and user related information, we sometimes wonder what are the possibilities beyond what we see and collect from surroundings. In a virtual world, we have the opportunity to demonstrate a possibility, showing, manipulating and effectively representing knowledge in a virtual spectrum.

While virtualization is a very heavy task, the power of representation of data, on the other hand, is very challenging. To be able to perceive data one may attempt to tag, create virtual charts, and tables, or create virtual relations between objects to represent connections. This in terms needs a reliable method of creating a U.I. which is (1) intuitive, (2) interactive, and (3) extendible.

A user interface, or U.I., is not limited to just visualization of data, but also the method of interaction in virtual reality. One may engage in a Homer selection methodology to interact with objects, and one may use point and fly to engage users to move around. Furthermore, displaying simple data and notifications is necessary to have within this virtual world.

As such, I have taken the opportunity to create a simple demonstration of how a Twitter engaged world would necessarily look like, what would be the interacting elements while keeping the simplicity of interactions in mind. Furthermore, I will discuss future possibilities and development options. 

## Why a Twitter App
Twitter is a fast-growing social media application with a public API and features that one can use to simply find references to recent tweets and topics. However, the goal of this project is to focus on the usability of an application beyond a 2D screen space and challenge the use of interactive gestures and movements to engage the audience within a virtual social media platform.

Twitter is simple enough for the purposes of this project to demonstrate complex interaction and generation of the environment to create a challenging virtual world.

## Why a Virtual App
In many ways, our interactions have been limited to a standard 2D interface where we collect information by scrolling and expanding feed on our cellphones or PCs. This project aims to seek ways to manipulate daily interactions and seek methods to engage the audience in more of a realistic searching world. 

One needs to look around at statues, and move around to seek them at the moment. However, with more expansion of the API one can simply generate a fully live environment where users can find feed connections and progression of immersion into the social area.

## Technicalities of Interaction
In this project, I have aimed to use the simplest method of interaction which is understandable for users, engaging, and powerful enough for further development - Ray Casting. The strength of ray casting can be demonstrated in two ways. (1) Users are lazy in general and do not want to move around and touch, (2) it can be effective in triggering items at any range.

In this V.R. world, there are two "data types"/"game objects" represented in the world which can be distinguished by their looks. (1) Pillars and (2) Bodies. Pillars hold the data about the current top 10 trending topics on Twitter. In the other hand, Bodies represent user/business/group accounts which are available on Twitter. Yet if we want to pull data we need a way to present vital information to the user.

With ray casting in place, there was a dire need for representation of data in close proximity of the user. This engaging method needed to be close, simple, moveable, and intractable for the user to cause changes, read materials, and effectively manipulate the environment. As such I have created a wrist panel. This panel spawns and attaches itself to the primary hand - in OVR primary hand is always left hand - and it can be easily touched and interacted with by the user.

The most important interaction/engagement that needs to be present in such application is seeing the related information. As such for the time being I have represented the tweets for each body like a paper piece which can be interacted with by grabbing, and upon throwing it on the ground you are able to respawn it on the table by ray casting it.

## Creating Simple and Understandable environment
As you may perceive the level of interactions for this app's U.I. is precise and to the point. Users are able to understand mostly what they are capable of, what they can achieve, and what is the limitation of this world around them.

The goal of this project is not to add too much collusion to create confusion but to present seamless and smoothness to interactions which users can take control of. This means that with the future introduction of more complex environments, one is able to produce more and more complex behaviors while keeping to the original or extended interfaces.

## Further development

| Published                                               | In Progress                                             |
|---------------------------------------------------------|---------------------------------------------------------|
|- Twitter integration                                    |- Click to expand to a tweets replies                    |
|- Displaying Twitter account info                        |- On screen gestured flydown menu                        |
|- Window pop-ups                                         |- VR gestures for pointing and selecting                 |
|- Raycasting to travel                                   |- Converting code for general use and future integration |
|- Added characters for better distinguishing accounts    |- Extending Twitter API                                  |
|- Created Small animation                                |- Search functionality for searching tweets/profiles     |
|- Wrist pop-up panel for more details and info           |- Respawning new top trends upon changes                 |
|                                                         |- Notifications and pop up tweets from present users     |

### YouTube Demo Video
[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/ELdF3X3kqTY/0.jpg)](https://youtu.be/ELdF3X3kqTY)]
