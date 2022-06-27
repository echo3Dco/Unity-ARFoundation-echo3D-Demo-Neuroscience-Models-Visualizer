# Unity-echo3D-demo-neuroscience-visualizer

Example Unity project with AR Foundation and echo3D integrated.

It will visualize brain, neuron, and spinal cord with text descriptions.

Build in Unity version 2019.2.

## Register

Don't have an API key? Make sure to register for FREE at [echo3D](https://www.echo3d.co/).

## Versions

For AR-supported Android devices

- Unity 2019.4.0f1
- [ARFoundation 3.1.0](https://www.youtube.com/watch?v=0mpsiO2lCx0)
- iOS Build Support

## Setup

1. Find the 3D models in in `Mod` folder. There are three models containing brain, spinal cord, and neuron.
2. Go to echo3D console and click "Add to Cloud" and upload these three models.
3. Set `name` metadata for these three models. E.g., `name: neuron`.

<img src="img/meta.png">

4. Clone the project and open up the SimpleAR scene.
5. Setup your API keys and the Object keys accordingly. (Remember to set both for the echo3D object and for the TextMeshPro).

```
Set API keys and Object keys for:
- ContentParent/spine
- ContentParent/spine/SectionInfo/InfoParent/Text (TMP)
- ContentParent/neuron
- ContentParent/neuron/SectionInfo/InfoParent/Text (TMP)
- ContentParent/brain
- ContentParent/brain/SectionInfo/InfoParent/Text (TMP)
```

6. Set up your Build Settings & Player Settings and export your build to your iOS device.

## How to Play

Walk around to see the models and their corresponding descriptions.

## Screenshots

<img src="img/1.PNG" width="200" height="400">

<br>

<img src="img/2.PNG" width="200" height="400">

<br>

<img src="img/3.PNG" width="200" height="400">

## Learn More

Refer to our [documentation](https://docs.echo3d.co/) to learn more about how to use FaceAR and echo3D.

## Support

Feel free to reach out at [support@echo3D.co](mailto:support@echo3d.co) or join our [support channel on Slack](https://echo3d.slack.com/ssb/redirect).
