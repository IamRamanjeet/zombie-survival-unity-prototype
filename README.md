# Zombie Survival — Unity Gameplay Prototype

A Unity first-person gameplay prototype focused on player movement, enemy AI, navigation, and animation systems.

## 🎮 Project Overview

This project explores the implementation of a first-person player controller and a basic zombie AI system.

The prototype demonstrates:

- Player movement
- Running, jumping and crouching
- First-person camera control
- Enemy detection
- Zombie AI behaviour
- NavMesh navigation
- Animator Controller systems
- C# gameplay scripting

## 🛠 Technical Details

| Area | Implementation |
|---|---|
| Engine | Unity |
| Programming | C# |
| AI Navigation | NavMesh |
| Animation | Animator Controller |
| Player | CharacterController |
| Camera | First-person camera |

## 🎥 Development Walkthrough

[Video coming soon]

## 🤖 Enemy AI

The zombie uses distance and viewing-angle checks to determine when to remain idle, move toward the player, or attack.

## 🎬 Animation System

The zombie Animator Controller contains states including:

- ZIdle
- ZWalk
- ZAttack
- ZFallingBack
- Exit

Animation parameters are controlled through the gameplay scripts.

## 📁 Project Structure

```text
Video/
Scripts/
Animator/
Screenshots/
Documentation/
