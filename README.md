# unity-6-sprite-render-anim-issue
Very basic project showcase a bug in Unity where changing a property on a Material via an animation causes it to render incorrectly

# Instructions

Steps to reproduce:

Start project up and open "SampleScene.unity" with Unity version 6000.0.33

Play the scene.

Click the "Change Shape 1" or "Change Shape 2" button - this will simply set the sprites of those sprites to a "Knob" sprite.

Notice how simply Changing Shape 1 will impact the sprite renderer of Shape 2, and vice versa. Also notice how moving the camera around and viewing the shapes at different angles causes them to visibly render different shapes.
