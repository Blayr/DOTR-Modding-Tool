# DOTR-Modding-Tool
A tool to modify the NTSC-U version of the game Yu-Gi-Oh! Duelists of the Roses.

## Install
Download the latest version from the [Releases page](../../releases).\
This tool currently only works on Windows with no plans of porting it to other platforms.

## Usage
Upon starting the program, you'll be prompted to select an ISO of game. This must be the NTSC-U (North American) version of the game, NTSC-J (Japanese) and PAL versions will not work.\
Once the ISO is loaded you'll have access to all the different tabs and forms used to modify the game.\
\
The save button only saves information to the ISO specific to that tab (saving on the Deck Leader Abilities tab will only save changes related to Deck Leader Abilities).

## Current Features
* Modify deck leader + cards of all decks in the game (Starter decks, tutorial decks, enemy decks)
* Modify global card properties such as Attack, Defense, Level, Deck Cost
* Adjust how cards are obtained in the game (Graveyard slots, 3 in a row, Reincarnation, Password)
* View + modify deck leader abilities of all monster cards (some limitations here, many abilities have hardcoded type specific logic)
* Modify what monsters equips cards work on (also includes marking a monster as being powered-up on toon terrain)
* Modify all fusion combinations (all 26540 of them).
* Change which AI each duelist uses
* Customize hidden card location and reward
* Adjust deck leader rank thresholds (no more grinding to get SD!)

## Plans for future releases
- Fix starter deck image load when picking your deck and allow modification of starter deck average summoning level / dominant types + attributes
- Integrate [Thotsicle's map editor](https://github.com/rjoken/DOTRMap) for a more complete modding experience
- Make hidden card editor more intuitive to use

## Tool orgranization
Due to the nature of how this tool was developed, things are grouped together based on how the associated information was stored on the game's disc.
This is why Deck Leader Abilities and Card Equip compatibility are not included in the Card Properties tab, they are stored in a different area of the disc than the rest of the card information.

Theres the possiblity of reorganizing the tool to be more intuitive, but it's fine how it is for now.

## License
This project is licensed under [GNU General Public License v3.0](./LICENSE)\
This project uses the [BindingListView library made by andrewdavey](https://sourceforge.net/projects/blw/)

## Acknowledgements
* GenericMadScientist - Did extensive reverse engineering and documented the inner working of the game.
* Clovis - His passion and dedication towards the game inspired me to create this tool for the purpose of fast-tracking his development of the [DotR Redux Mod](https://www.youtube.com/watch?v=E_Aa2xC0Gig&ab_channel=Clovis).
