# Design Patterns

## CQRS Pattern (Command and Query Responsibility Segregation)

CQRS pattern states that we must separate the operations for reading the data from the operations for writing or updating the data.

### Advantages of doing this

- Separate teams can work on these operations
- Each can be made to scale according to their own needs.
- Each can have their own security as per requirements
- Read operations can have a different architecture to support caching, conversions to data transformation objects as required by clients
- Write operations can include data validation. lookups etc

### When need to use

This pattern is better suited to larger applications where the requirements and load levels between read and write operations are different.
**File Structure**

![Application file structure](/img/FileStrut.jpg)
**Output**

![Output for the application](/img/Output.jpg)
