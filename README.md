# MG7
## Devlog
Write your Devlog here. :3

My TreeOfBirds script let the birds become active when player approach them. First I create an array _birds to store all the Sparrow GameObjects  except Sparrow_Start in the scene. Then, I use a foreach loop in the Update() method to check every bird in the array in each frame. And the script uses Vector3 to calculate the distance between each bird and the player. Vector3.Distance() compares the bird's position and the player's position. If the distance is smaller than or equal to the interaction distance, the script uses SetActive(true) to activate that bird. In this way all birds can appear when the player approaches the tree.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
