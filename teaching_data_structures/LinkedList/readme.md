## Linked Lists:
We made a linkedlist using the custom classes [Node< T >](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/master/teaching_data_structures/LinkedList/Node.cs). <br>
All additional functions like adding/removing/contains node are in a class called ListOperation.

#### Custom ListOperations functions: 
- [AddToTail< T >](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/cd6b565f7bee32451773ad4a355d961aef7c2727/teaching_data_structures/LinkedList/ListOperations.cs#L6) -
  will add a Node< T > to the last node in the linked list.
- [ToString < T >](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/cd6b565f7bee32451773ad4a355d961aef7c2727/teaching_data_structures/LinkedList/ListOperations.cs#L18) -
  will convert the linked list into string and return it
- [Contains](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/cd6b565f7bee32451773ad4a355d961aef7c2727/teaching_data_structures/LinkedList/ListOperations.cs#L31) -
  will return true if the desired value is in the list, false otherwise
- [GetMax](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/cd6b565f7bee32451773ad4a355d961aef7c2727/teaching_data_structures/LinkedList/ListOperations.cs#L59) -
  will return the maximun int value inside of an Node< int > linked list
- [Insert](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/cd6b565f7bee32451773ad4a355d961aef7c2727/teaching_data_structures/LinkedList/ListOperations.cs#L73) -
  will insert a new node< T > in a specified position in the linked list