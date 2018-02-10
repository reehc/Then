## Memory stuff...
- arguments order: rdi,rsi,rdx,rcx,r8,r9
- leaq (%rdi, %rsi, 4), %rax ; return x+4y, use memory addressing to simplify calculation.
- asm(b w l q), gdb(b h w g), byte(1 2 4 8), type(char short int long)
- GDB with assembly: ni&si instead of n&s
- %fs:0x28 is a sentinel in case of stack overflow, and fs is a segment register.

## I try and I am right???!!!
- In phase 4, I seems to know the first number less or equal than 14 and the second number is 0. My first try is 0 & 0 and... I cracked right! 
- In phase 5, I use ```x/10s 0x...``` and accidently find the final word, though I haven't figure the last one out...
- Most of time, I am just thinking about the content of assembly programs, but use gdb less. Maybe I'm not in a broad way.
