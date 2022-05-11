# HungryShark
Hungry Shark
LUVBUG LEARNING TECHNICAL TEST

Overview: 

For this test, I completed a prototype of Hungry Shark - a game where the player is a shark swimming through the ocean eating fish and avoiding jellyfish. 

Player Movement:

Starting this project, my main plan was to build a game where the objective was immediately clear and where controlling the character was intuitive and felt fun. 
To accomplish this, I started off by working on a simple character controller: to work best with a touch interface all control is done through tapping (or clicking) on 
the screen. After the first tap, the player will see that the shark scoots toward their tap location, and from there the player can start swimming and chasing fish.

Adding Fish & Jellyfish

Next up, I worked on the logic and design for the other fish: the prompt asks for both target fish and incorrect fish. In the case of my prototype, I am using appetizing green fish as the targets and menacing purple jellyfish as the “incorrect fish”. I hoped to leverage the intuitive association of jellyfish with stinging to indicate to the player that they are to be avoided. 
My next step was setting up motion for all the fish - to efficiently accomplish this I built a fish movement script that is shared between each fish with variables accessible in the inspector to allow the designer to tweak and give each fish the intended behaviour. 

Adding Shrimp

My final touches on the project was adding a shrimp, which swims like a fish and awards bonus points, but more importantly – it eats jellyfish! The player is supposed to chase the shrimp but eventually notice that they are eating up the jellyfish, which introduces more strategy as the player might leave them swimming around to clean up some of the jellyfish to make the player’s swimming safer! 

The Chubby Shark

As a way to introduce progressive challenge (and as a little bit of personality!) I set the shark to scale up as it eats fish. This makes the lucky shark fatten up as it feeds - but it also makes the game a little more difficult, as weaving through tight spaces gets more challenging as the player collects more points! 

Issues:

Getting Enemy Movement Right

Setting up the enemy movement proved to be the most challenging obstacle for this prototype. Accomplishing the intended unpredictable and “lifelike” movement from the fish took some fine tuning and iteration (testing different ways to incorporate randomness, experimenting with behaviour when they collide with each other or with the edges of the screen, etc). I am happy with the solution I landed on though: sending each fish in a random direction at random intervals (within a range set by the designer) gives them a little chaotic energy, which is perfect for quick play sessions! 


Where it can be improved:

More granular shark swimming

Since I wanted to get the player movement implemented first so that I could test it with all other features as I added them, I kept the shark’s movement fairly simple: it automatically swims slowly and can be boosted and redirected by tapping on the screen. 
This could be improved considerably with some more tuning to the way the shark responds to the player’s input: gradual turning towards the tapped direction (Perhaps using a Slerp) could make for more organic movement. And adding more speed for consecutive taps would add more frantic fun to the gameplay, encouraging the player to rapidly tap to rush across the screen (or slowly tap for precise steering!). 

Optimization

As a prototype, I didn’t dedicate much attention to optimizing the project. A quick next step for a project of this type would be to implement a simple object pool to reduce the runtime instantiation and destroying of gameobjects, which should improve performance on older devices. 




