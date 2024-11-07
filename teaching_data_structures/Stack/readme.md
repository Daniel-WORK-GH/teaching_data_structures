## Stack:
We made a stack called [MyStack< T >](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/master/teaching_data_structures/Stack/MyStack.cs). 


#### Stack Using Array: 
- [void Push(T value)](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L12) -
  will add the value to the stack.
- [T Pop()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L18) -
  will remove the last item and return it.
- [T Peek()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L25) -
  will return the last item without removing it.
- [bool IsEmpty()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L25) -
  will return true is the stack is empty, false otherwise.
- [bool IsFull()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L35) -
  will return true if the stack array is full, false otherwise.
- [bool Contains(T value)](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L40) -
  will return true if the desired value is in the stack, false otherwise.
- [void SwapLast2()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/a7f4c9c6eef2c27b7a61a05b8faaf4cdacf092fc/teaching_data_structures/Stack/MyStack.cs#L51) -
  will swap the last 2 elements in the stack.

## Stack Using List:
- [void Push(T value)](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L14) -
  will add the value to the stack.
- [T Pop()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L29) -
  will remove the last item and return it.
- [T Peek()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L42) -
  will return the last item without removing it.
- [int GetSize()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L53) -
  will return the size of the stack.
- [bool IsEmpty()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L58) -
  will return true is the stack is empty, false otherwise.
- [bool Contains(T value)](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L63) -
  will return true if the desired value is in the stack, false otherwise.
- [StackList<T> Reverse()](https://github.com/Daniel-WORK-GH/teaching_data_structures/blob/570e7a92b918d9d53abe39e7f077fa08dff9455d/teaching_data_structures/Stack/StackList.cs#L82) -
  will reverse the stack and return a copy without affecting the original stack.
