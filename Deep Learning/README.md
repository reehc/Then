## Tips
1. ```[f for f in dir(dict) if callable(getattr(dict, func)) and not f.startswith("  ")]``` to examine functions of a class.
2. In numpy, integer index gets you a lower rank arary, while slice index won't change your rank.
