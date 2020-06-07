"""
WEEK 4: Practice Assignment 1
"""

# WHAT YOU SHOULD DO ON YOUR OWN EXERCISE
# 1. There's an error in this script. What is it?
# 2. I used 4.0 for 'space_in_a_car', but is it necessary? What happenes if it's just 4?
# 3. Remember that 4.0 is a "floating point" number. Find out what that means.
# 4. Write comments above each of the variable assignments.
# 5. Make sure you know what '=' is called (equals) and that it's making names for things.
# 6. Remember '_' is an underscore character.

cars = 100
space_in_a_car = 4  # Using '4' instead of '4.0' turns 'carp'
drivers = 30
passengers = 90
cars_not_driven = cars - drivers
cars_driven = drivers
carpool_capacity = cars_driven * space_in_a_car
average_passengers_per_car = passengers / cars_driven

print("There are", cars, "cars available.")
print("There are only", drivers, "drivers available.")
print("There will be", cars_not_driven, "empty cars today.")
print("We can transport", carpool_capacity, "people today.")
print("We have", passengers, "to carpool today.")
print("We need to put about", average_passengers_per_car, "in each car.")
