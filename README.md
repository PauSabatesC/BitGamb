# BitGamb API
## Official repository for the open source project BitGamb.
---
###### About the project

The idea of this project is to create a gambling game (that uses fake money) but using just an API Rest. So it can be played from any client the people do.
For example someone can play it using a webpage, or a mobile app, or even using Postman or a terminal! And all user data or bets will remain the same, and it can be easily treated. 
This project is open source and it's created for educational purposes (I love .net core and asp.net core is amazing). A guide with dev installation is located at the end of the readme. Hope you enjoy!

---

> ** Rest API endpoints: **

- |-->GET /auth/login
    - --> .netcore Startup class application builders configuration called 
    - --> AuthController class handles de http POST petition and uses IAuthRepository interface to work with the database 
          (*doing so we can change database methods implementation and API controller will still work, so basically: **Repository Pattern***)
    - --> AuthRepository interface's implementation connects to database using the Users class model mapped with EntityFramework.
          (*Actually the AuthRepository class doesn't interact with the user class model directly, **DTOs** are also used in this project*)

- |--> POST /race/bet
    - --> User bets for a robot name.
    - --> System withdrawns 10% of user bet.
    - --> Robot id, robotRace id and user id is added to race registries.
    - --> When system detects 30 min has passed, the algorithm decides a robot id for 1st, 2nd, 3rd and saves to RobotRaces.
    - --> The system selects userId from RaceRegistries where robotRaceID==robotraceid and robotId==LastRace_First. And the same for 2nd and 3rd.
    - --> The system adds reward to userId.bits accordingly.

All other endpoints:

- |-->POST /auth/register
    - --> User sends a username and password to create account

- |--> GET /*username*
    - --> Username and its bits are shown. It can be checket by any user.

- |--> GET /race
    - --> Active race information is shown to user and has 30 min to bet.

---

**~~~ Algorithm documentation: ~~~**

TODO

---

**~~~ Database documentation: ~~~**

TODO

**~~~ Installation guide (development): ~~~**

TODO