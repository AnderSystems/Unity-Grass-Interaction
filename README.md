<h1>Grass Collision Solution in Unity URP</h1>

<h2>Description</h2>
<p>This repository contains a custom solution for grass collision in Unity URP. Unlike traditional methods that create a single collision point, this approach uses an orthographic camera to render a top-down view and applies the rendered image as a collision mask on the grass. The solution includes a custom shader that lowers the grass based on the alpha channel of the texture.</p>

<h2>Features</h2>
<ul>
  <li><b>Orthographic Camera</b>: Captures a top-down view of the scene, synchronized with the main camera.</li>
  <li><b>Render Mask</b>: Renders only the objects that interact with the grass.</li>
  <li><b>Custom Shader</b>: Uses the alpha channel to lower the grass in the collision areas.</li>
  <li><b>Pixel Perfect Update</b>: Ensures stable rendering by updating camera coordinates with integer values.</li>
</ul>

<h2>Limitations</h2>
<ul>
  <li><b>Distance</b>: The effectiveness depends on the rendering distance of the collision camera.</li>
  <li><b>Quality</b>: Higher texture resolution improves collision precision but increases computational load.</li>
  <li><b>Object Height</b>: The system only captures a top-down map, which may cause grass to move even if the object is not directly colliding with it.</li>
</ul>

<h2>How to Use</h2>
<ol>
  <li>Clone the repository.</li>
  <li>Open the project in Unity.</li>
  <li>Assign the orthographic camera and configure the render mask.</li>
  <li>Apply the custom shader to your grass material.</li>
  <li>Adjust the settings as needed to fit your scene.</li>
</ol>

<h2>Contributing</h2>
<p>Feel free to fork this repository and submit pull requests. Any contributions to improve the solution are welcome!</p>

<h2>License</h2>
<p>This project is licensed under the MIT License.</p>
