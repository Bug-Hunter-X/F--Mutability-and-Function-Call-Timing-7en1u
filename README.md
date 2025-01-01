# F# Mutability and Function Call Timing Bug

This repository demonstrates a subtle bug related to mutability and function call timing in F#. The code calculates the sum of two mutable variables, but unexpectedly, changing the values after the initial call to the `add` function does not change the previously calculated sum. This highlights a key difference between how mutability works in functional and imperative programming paradigms.