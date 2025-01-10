# unity-6-sprite-render-anim-issue
Very basic project showcase a bug in Unity where changing a property on a Material via an animation causes it to render incorrectly

# Instructions

Steps to reproduce:

Start project up and open "SampleScene.unity" with Unity version 6000.0.33

Play the scene.

Click the "Change Shape 1" or "Change Shape 2" button - this will simply set the sprites of those sprites to a "Knob" sprite.

Notice how simply Changing Shape 1 will impact the sprite renderer of Shape 2, and vice versa. Also notice how moving the camera around and viewing the shapes at different angles causes them to visibly render different shapes.

![SpriteRenderIssue](https://github.com/user-attachments/assets/b432ebf5-723f-4368-a20c-aadbb31cda79)

# Details

This is a regression from Unity 2021, in which this not does not happen. The issue is that having an animator that contains animation clips related to modifying material properties breaks the sprite renderer.

I've reported a similar issue but related to Mesh Renderers going invisible, although it feels like the same underlying issue:
https://github.com/DeanIsseyegh/unity-6-mesh-renderer-anim-issue/blob/main/README.md
