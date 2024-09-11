<b>Grass Collision Solution in Unity URP</b>
Description
This repository contains a custom solution for grass collision in Unity URP. Unlike traditional methods that create a single collision point, this approach uses an orthographic camera to render a top-down view and applies the rendered image as a collision mask on the grass. The solution includes a custom shader that lowers the grass based on the alpha channel of the texture.

Features
Orthographic Camera: Captures a top-down view of the scene, synchronized with the main camera.
Render Mask: Renders only the objects that interact with the grass.
Custom Shader: Uses the alpha channel to lower the grass in the collision areas.
Pixel Perfect Update: Ensures stable rendering by updating camera coordinates with integer values.
Limitations
Distance: The effectiveness depends on the rendering distance of the collision camera.
Quality: Higher texture resolution improves collision precision but increases computational load.
Object Height: The system only captures a top-down map, which may cause grass to move even if the object is not directly colliding with it.
How to Use
Clone the repository.
Open the project in Unity.
Assign the orthographic camera and configure the render mask.
Apply the custom shader to your grass material.
Adjust the settings as needed to fit your scene.
Contributing
Feel free to fork this repository and submit pull requests. Any contributions to improve the solution are welcome!

License
This project is licensed under the MIT License.
