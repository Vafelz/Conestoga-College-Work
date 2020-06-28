"""
String formatting

Begin by executing this script from the command line by typing
    `$ python assignment.py`


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

Note:  Use the system's current time wherever there is mention of
       today's date, or the current time (i.e. .today()). Do not hard
       code the date which you completed the assignment.


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

##Place any import statements here##

def question_1():
    """
    Return the following variables as a concatenated string
    using the "old-style" formatting. The result should be
    "Hello World".
    """
    word1 = "Hello"
    word2 = "World"
    return


def question_2():
    """
    Return the following variables as a concatenated string
    using the "new-style" formatting. The result should be
    "Hello World".
    """
    word1 = "Hello"
    word2 = "World"
    return


def question_3():
    """
    Return the following variables as a concatenated string
    using an f-string. The result should be "Hello World".
    """
    word1 = "Hello"
    word2 = "World"
    return


def question_4():
    """
    Return the following variable 1234.9 as a dollar currency
    value. It should be prepended by the $ symbol and have 2
    decimal places.
    """
    amount = 1234.9
    return


def question_5():
    """
    Return the following variable as a percentage value (i.e. 25%).
    """
    value = 0.25
    return


def question_6():
    """
    Return the following as a string including the positive sign.
    """
    value = 1234
    return


def question_7():
    """
    Return the following value as a dollar currency value including
    comma separators. (E.g. $123,567,90.00)
    """
    amount = 29430435872349.3283
    return


def question_8():
    """
    Return the following integer as a North American telephone
    number (e.g. (xxx) xxx-xxxx)
    """
    number = 4165551234
    return


def question_9():
    """
    Return the following integer with leading zeros so that
    it occupies 4 characters (e.g. 0001)
    """
    number = 72
    return


def question_10():
    """
    Return a string which repeats the * character exactly 50 times.
    """
    return


def question_11():
    """
    Return the phrase "Hello World" centered within a series of *
    characters. The total length of the string should be 79 characters.

    E.g. *** Hello World ***
    """
    return


def question_12():
    """
    Return today's date in the following format: Jan 01, 2019
    """
    return


def question_13():
    """
    Return today's date in the following format: January 01, 2019.
    """
    return


def question_14():
    """
    Return today's date in YYYY-MM-DD format.
    """
    return


def question_15():
    """
    Return tomorrow's weekday name (i.e. if today is Friday,
    tomorrow is Saturday)
    """
    return


def question_16():
    """
    Return the current time in 24 hour format with seconds.
    (i.e. 23:21:03)
    """
    return


def question_17():
    """
    Return the current date and time in ISO-8601 format.
    """
    return


def question_18():
    """
    Return the current time using AM/PM (e.g 01:34 PM)
    """
    return


def question_19():
    """
    Reformat the following string into 24-hour date format (03:36)
    """
    x = '3:36 AM'
    return


def question_20():
    """
    Using the strptime function, return the following string
    as a date object.
    """
    my_date = '2014-12-20'
    return


def question_21():
    """
    Using the strptime function, convert and return the following
    as a datetime object.
    """
    my_datetime = '2014-12-20 23:12'
    return


def question_22():
    """
    Subtract 5 hours from the current datetime and return.
    """
    return


def question_23():
    """
    Add 7 days to the current datetime and return.
    """
    return


def question_24():
    """
    Return the following string as a date object. Assume that
    a week begins on a Sunday.
    """
    my_date = 'Day 2 of week 23, 2020'
    return


def question_25():
    """
    Return the last three characters of the following string.
    """
    alphabet = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
    return


def question_26():
    """
    Using today's date, how many days have elapsed since the
    beginning of the year? (e.g. If today is Jan 3, there would
    be 2 days). Return as an integer.
    """
    return


def question_27():
    """
    How much time is left this year? Return a timedelta.
    """
    return


def question_28():
    """
    How many seconds are left this year? Return an integer.
    (Hint: look for a helper function on timedelta)
    """
    return


if __name__ == '__main__':
    for num in range(1, 29):
        func = eval(f'question_{num}')
        question = ' '.join(func.__doc__.split())
        print(f'Question {num}: {question}')
        print(f'    {func()}\n\n')
