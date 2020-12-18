# interview-task-.NET

This web application serves as a code demonstration for the job interview in Tieto.


TASK:
Part 1
- Create an API in C#
- API will have 2 methods, one for getting heat contract and second for getting electricity contract
- Both heat and electricity contracts have price and name
- Heat contract also provide set of temperatures
- Electricity contract contain building type
- building type have 3 possible values: Flat, House and Other
-Both methods will return some fake data (whatever you like)

Part 2
- Create Angular or jQuery application that consumes this API
- Display gathered Electricity and Heat contracts next to each other (electricity on the right, heat on the left)
- Ensure that on small screen, contracts will be under each other



# My solution
API includes classes that implement these Contracts (Models), which are then controlled in Contract controllers (Controllers).
I implemented the 2 methods to get both of the contracts in these seperate controllers, but there are also methods for getting the
whole enumerable list of all created objects, for testing purposes.

Website is a simple bootstrap/jquery powered html webpage that shows this data in a size-responsive columns.
