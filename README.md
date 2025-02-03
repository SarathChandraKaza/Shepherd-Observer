# Shepherd Observer 🐑👀


A gamified Unity project demonstrating the Observer Pattern using an analogy of sheeps. The Mother Sheep (Subject Class) acts as the subject, and the Son and Daughter sheep act as observers. When the mother moves or jumps, all observing sheep follow her actions.


📌 What is the Observer Pattern?
The Observer Pattern is a behavioral design pattern where an object (the Subject) maintains a list of dependents (the Observers) that need to be updated whenever the subject's state changes. This helps in loosely coupling objects.


📝 In this project:-
Mother Sheep (SubjectClass) = Subject
Son & Daughter Sheep (IMovement Implementers) = Observers
ManagerClass = Manages Observers and Notifies Changes


🎮 How It Works:-
1. Mother Sheep moves → She moves based on player input (buttons or keyboard).
   
2. Observers (Son & Daughter) follow → Whenever the mother moves, all observer sheep also move in the same direction.
   
3. Decoupled Interaction → Observers don’t directly interact with the mother; they just respond to notifications from the subject.


   
🛠️ Project Structure:-
1. SubjectClass (Mother Sheep)
Handles user input (buttons/keys).
Moves itself and notifies all observers.

2. ManagerClass (Observer Manager)
Maintains a list of all observers.
Notifies them when an action occurs.

3. Son & Daughter (Observers)
Implement IMovement interface.
React to the subject's notifications.

4. IMovement (Interface)
Defines movement actions.


🚀 Code Flow
1. Observers Register: 
When the game starts, Son and Daughter register themselves with SubjectClass.

2. User Input (Mother Moves):
When a button or key is pressed, SubjectClass moves the mother and notifies all observers:

3. Observers Respond:
When notified, each observer (Son & Daughter) executes the corresponding movement.


⚠ If you have any questions, feel free to open an issue. 
