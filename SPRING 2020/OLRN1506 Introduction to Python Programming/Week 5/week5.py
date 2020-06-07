"""
WEEK 5

June 9-15
Built-in Types: Strings, Lists and Tuples
|----------------------------------------------------------------------|
STRINGS

Strings are variables that stores text
'\n' can be used for new line
|----------------------------------------------------------------------|
LISTS

Lists are data types that contain a group of elements

CREATING A LIST
name = [values,...]

ACCESSING ELEMENTS
len(name) - Gets the length of a list
name[i] - Gets the value at 'i' position of 'name'.list
Using 'i' position not in list will return an IndexError

name[-i] - Gets value at 'i' position from end of 'name'.list

SLICING
name[start:stop] - Gets an items from 'start'.position to 'stop'.position
name[start:] - Gets an items from 'start'.position to end of list
name[:stop] - Gets an items from beginning to 'stop'.position of list
name[:] - Gets an entire list

MANIPULATING LISTS
name.append(value) - Adds new element to the end of a list

name.insert(i, value) - Adds a new element at 'i'.position of a list

name.pop(i) - Removes an item from the list at 'i'.position. If left blank will remove the last item
|----------------------------------------------------------------------|
TUPLES

Tuples are like lists but are immutable (once created cannot be modified)

EXAMPLES:
(1) - not a tuple
(1,); (x, y, z) - a tuple
|----------------------------------------------------------------------|
SETS

Sets can contain multiple items but are unordered.

CREATING A SET
name = {values,...}
|----------------------------------------------------------------------|
DICTIONARIES

Dictionaries are key-value mappings of data. Values are identified by a key.
Keys are immutable data types like strings, ints or tuples.

CREATING A DICTIONARY
name = {'i': 'value', 'j': 'value'}

name['i'] - Prints value with 'i'.key
name['i'] = 'value' - Creates new 'i'.key with 'value'.value
name.get('f') - Tries to get value with 'f'.key, returns 'None' if 'f' doesn't exist
del name['f'] - Removes 'f'.key. Returns KeyError if 'f' doesn't exist
name.pop('f', None) - Removes 'f'.key. Returns 'None' if 'f' doesn't exist
"""
