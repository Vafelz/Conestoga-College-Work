"""
WEEK 6

June 16-22

MODULE OBJECTIVES
- Identify the different string formatting and interpolation methods
- Bind data to string templates
- Print and format numbers
- Print dates and times in various formats

|----------------------------------------------------------------------|

STRING FORMATTING IN PYTHON

    Concatenation:
        a = 'Hello'
        b = 'World'
        print(a + ' ' + b + '!')
        => Hello World!

    Old printf-style formatting using % symbol:
        fname = 'George'
        lname = 'Costanza'
        print('Hello, %s %s.' % fname, lname)
        => Hello, George Costanza.

    "New" style .format():
        fname = 'George'
        lname = 'Costanza'
        print('Hello, {} {}'.format(fname, lname))
        => Hello, George Costanza
        print('Hello, {f} {l}'.format(l=lname, f=fname))
        => Hello, George Costanza

    Literal string interpolation (f-string):
        fname = 'George'
        lname = 'Costanza'
        print(f'Hello, {fname} {lname}')
        => Hello, George Costanza

        print(f'2 x 2 = {2 * 2}')
        => 2 x 2 = 4

NUMBER FORMATTING IN PYTHON

    Decimal precision:
        x = 1234
        print(f'{x:.2f}')
        => 1234.00

    Percentage:
        x = 1 / 3
        print(f'{x:%}')
        => 33.333333%

        print(f'{x:.1%}')
        => 33.3%

    Sign:
        x = 37
        print(f'{x:+}')
        => +37

    Padding:
        x = 9
        print(f'{x:3}')
        =>   9

        x = 99
        print(f'{x:3}')
        =>  99

        x = 100
        print(f'{x:3}')
        => 100

        x = 9
        print(f'{x:03}')
        => 009

    Thousands separator:
        x = 123456.78
        print(f'{x:,}')
        => 123,456.78

FORMATTING TEXT

    Padding:
        x = 'Hello'
        print(f'{x:10}')
        => Hello

        print(f'{x:<10}')
        => Hello

    Right align / left padding:
        print(f'{x:>10}')
        =>      Hello

    Centered:
        print(f'{x:^10}')
        =>    Hello

    Fill with character:
        print(f'{x:-^11}')
        => ---Hello---

    Truncation
        alphabet = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
        print(f'East as {alphabet:.3}')
        => Easy as ABC
"""
