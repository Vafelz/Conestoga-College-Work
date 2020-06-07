"""
Assignment #1 (Module 3): Built-in types and functions

Begin by executing this script from the command line by typing
    `$ python assignment_1.py`


This script will print out all the questions and the returned value. This
script must execute without error.

Each question is a fill-in-the-blank and ends with a blank
`return` statement. Provide the answer to the question following
the return statement.

Sample question:

    def question():
        '''What is 2 + 2?'''
        return

    Answer:
        return 2 + 2

Note: the assignment is an evaluation of the usage of built-in types and
      functions. In the example above, return the equation 2 + 2, not the
      number 4.

Some questions have variables in them, and will need manipulation. In that
case, perform whatever transformations to the variable, and make sure that
it is returned.

Example:
    def question():
        '''Do something to variable x and return.'''
        x = 'a variable'
        ... code that does stuff to x ...
        return x
"""


def question_1():
    """Return a tuple containing a single item."""
    t = ('frogs',)
    return t


def question_2():
    """Return a list of strings."""
    listOfStrings = ['aussies', 'border', 'german', 'shepards', 'labradors']
    return listOfStrings


def question_3():
    """Return a list of floats."""
    listOfFloats = [4.0, 31.2, 10.5, 7.3]
    return listOfFloats


def question_4():
    """
    Return the following list in reverse order, using the sort
    built-in function.
    """
    numbers = [10, 20, 30, 40, 100]
    numbers.sort(reverse=True)
    return numbers


def question_5():
    """
    Using the append built-in function, add the number 200 to the
    following list, and return.
    """
    numbers = [197, 198, 199]
    numbers.append(200)
    return numbers


def question_6():
    """
    Using a built-in function, insert the value `banana` after `orange`
    and return.
    """
    fruits = ['orange', 'tomato']
    fruits.insert(1, 'banana')
    return fruits


def question_7():
    """
    Using a built-in function, remove the value 2 from the following list
    and return.
    """
    numbers = [1, 2, 3, 4, 5]
    numbers.pop(1)
    return numbers


def question_8():
    """
    Using the slice function, return the last element from the following list.
    """
    words = ['fizz', 'buzz', 'foo', 'bar']
    return words[3:]


def question_9():
    """
    Using the slice function, return the value 'c' from the following list.
    """
    letters = ['a', 'b', 'c', 'd', 'e']
    return letters[2:3]


def question_10():
    """
    Using the slice function, return the first two element in the list.
    """
    letters = ['a', 'b', 'c', 'd', 'e']
    return letters[:2]


def question_11():
    """Return the sum of 2 and 3 (use addition)."""
    sum = 2 + 3
    return sum


def question_12():
    """Return the difference of 100 and 1 (use subtraction)."""
    diff = 100 - 1
    return diff


def question_13():
    """Return the product of 7 and 5 (use multiplication)."""
    prod = 7 * 5
    return prod


def question_14():
    """Return the quotient of 10 and 3 (use division)."""
    quot = 10 / 3
    return quot


def question_15():
    """
    What is the data type of the value returned by: 4 / 2? Return the data
    type. Example if your answer is "string" or "list", then return the data
    type like this: `return str` or `return list` (do not include the quotes).
    """
    quot = 4 / 2
    return type(quot)


def question_16():
    """What is the data type of the number 9?"""
    return type(9)


def question_17():
    """What is the data type of the number 3.0?"""
    return type(3.0)


def question_18():
    """What is 4 to the power of 3?"""
    return 4**3


def question_19():
    """Return the variable `value` as an integer."""
    value = 1 / 3
    return int(value)


def question_20():
    """Return the variable `value` as a float."""
    value = 2
    return float(value)


def question_21():
    """Return a string containing single quotes."""
    string = "Look, a quote: 'hello'"
    return string


def question_22():
    """Return a string containing double quotes."""
    string = 'Oh lordy lord, two quotes: "The sky is purple"'
    return string


def question_23():
    """Return a string that spans multiple lines."""
    multi = """
    This seems
    to be a
    pretty long
    Sentence
    """
    return multi


def question_24():
    """
    Using a built-in function, return the following text
    as all uppercase.
    """
    text = 'The quick brown fox jumps over the lazy dog'
    return text.upper()


def question_25():
    """
    Using a built-in function, return the following text as
    title case (i.e. every word starts with a capital letter).
    """
    text = 'The quick brown fox jumps over the lazy dog'
    return text.title()


def question_26():
    """
    Return a string containing the backslash character.
    """
    back = "This is a backslash= \\"
    return back


def question_27():
    """Return a string containing both single and double quotes."""
    r = """A 'single' and a "double" quote?!"""
    return r


def question_28():
    """
    Return a dictionary containing the three most populous
    Canadian provinces. Use their code as the key, and the
    full name as the value. Example "AB" - "Alberta"
    """
    my_dict = {'BC': 'British Columbia', 'ON': 'Ontario', 'QC': 'Quebec'}
    return my_dict


def question_29():
    """
    Return the value of the key "c" from the dictionary by
    using the key as the index.
    """
    my_dict = {'a': 3, 'b': 2, 'c': 7}
    return my_dict['c']


def question_30():
    """
    Extend and return the following dictionary by adding the following
    key/value pair: b, 10.
    """
    my_dict = {'a': 1}
    my_dict['b'] = 10
    return my_dict


def question_31():
    """
    Return the unique values from the following list.
    """
    my_list = [1, 2, 2, 1, 3, 3, 2]
    listSet = set(my_list)
    return listSet


if __name__ == '__main__':
    for num in range(1, 32):
        func = eval(f'question_{num}')  # pylint: disable=eval-used
        question = ' '.join(func.__doc__.split())
        print(f'Question {num}: {question}')
        print(f'    {func()}\n\n')
