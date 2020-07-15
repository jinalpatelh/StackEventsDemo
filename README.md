# StackEventsDemo

we will create a class that exposes events.The class will mimic a stack data structure and expose two events 1) when an item is push on the stack 2) when an item is popped off the stack. Internally in the class the stack will be represented with a List<T> structure but externally it will mimic a stack (last-in-first-out). The data items the stack contains must be assignable by the developer using the class (e.g. generic). Clients listening for the push and pop events will write out to the console that an item has been added and an item has been removed respectively.
  
•	Create your custom class
•	Create the private list inside of the class
•	Create the Pop and Push methods.
•	Create the code for the two events (one for pop and one for push)
•	Create code instantiating the class
•	Associate the stack events with code to listen for the events and write the appropriate messages to the console.
