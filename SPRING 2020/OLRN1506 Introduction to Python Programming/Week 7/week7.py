"""
WEEK 7

June 23-29

MODULE OBJECTIVES
- Identify the different string formatting and interpolation methods
- Bind data to string templates
- Print and format numbers
- Print dates and times in various formats

|----------------------------------------------------------------------|

WORKING with DATES

Import syntax:
    # Imports a whole package or module
    import <module>

    # Import a specific part of a package or module
    from <module> import <module/object>

    # Import an object that is deeper in the package structure
    from <module>.<module> import <object>

Date, Time and Datetime types:
    dates:
        The 'date' object accepts values for a year, month and day.
        e.g.
            from datetime import date
            date(2008, 12, 31)
            => datetime.date(2018, 12, 31)

    time:
        The 'time' object accepts values for the hour, minute, second, microsecond, and timezone.
        e.g.
            from datetime import time
            time()
            => datetime.time(0, 0)
            time(22, 14, 30, 9999)
            => datetime.time(22, 14, 30, 9999)

    datetime:
        The 'datetime' object is a combination of both 'date' and 'time'.
        With 'dates', the 'year', 'day' and 'month' values are required, whereas 'time' is optional.
        e.g.
            from datetime import datetime
            datetime(1900, 1, 1, 13, 30)

    Operations with dates:
            import datetime
            datetime.datetime.today() - datetime.datetime(2000, 1, 1)
            => datetime.timedelta(6759, 78612, 392763)

        print(datetime.today() - datetime(2000, 1, 1))
        => 6759 days, 21:50:25.984492

    timedelta:
        The 'timedelta' object represents a difference in time and can be used to add or subtract.
        e.g.
            import datetime
            datetime.datetime(2000, 1, 1) + datetime.timedelta(days=2)
            => datetime.datetime(2000, 1, 3)

Parsing and Formatting Dates:
    Formatting the String Output:
"""
