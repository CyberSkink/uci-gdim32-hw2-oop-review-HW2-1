# HW2
## Devlog
Write your Devlog here!


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites

### Devlog

#### Penguin
Collision with the ground was the easy part as the rigidbody is an attribute of the pengiuin, which makes it easy, since all that is left to add after that are 2 box colliders. This cooresponds to the action arrows and text in the diagram. The penguin can also jump, which is an action arrow, but is pretty simple to do in code.

#### Coin
The Coin has a trigger attribute, as well as a spawner, the coin is deleted by the player character when triggered by it. This cooresponds to the diagram's arrows and bubble text pretty much 1 to 1.

#### Coin Spawner
The coin spawner has an action where it randomly spawns a coin at a range of intervals. These intervals are what show up in the game. The coin spawner is an empty, which is why the diagram's entry is mostly blank.

#### Ground
A simple box collider with a color taped ontop of it, nothing special. The diagram falsly displays a need for a static rigidbody, where there is no need for one.

#### UI

Using Text Mesh Pro, the UI is changed when the coin is touched by the penguin. This adds the value of the coin to the overall score, the value needs to be converted to a string first. The UI's diagram counterpart is pretty much 1 to 1.

#### Improvments to be made
Moving forward, it would be nice to fix the double first coin glitch.