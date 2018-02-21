/* 	Lex: A lexical analyzer generator */

/*
 * Guide: 
 *	1. Enter command: flex simple.l or lex simple.l
 *  2. A file called "lex.yy.c" appear
 *	3. Enter command: gcc lex.yy.c -lfl or gcc lex.yy.c -ll
 *  4. Executable file "a.out" appear
 *
 * Note: 
 *  1. Ctrl+D to end input.
 *  2. Flex file contains three parts: ...definitions...rules...subroutines..
 *		and all is optional.
 *	3. Don't use // to comment, you may find. 
 */

/* Definitions */
%{
#include <stdio.h>
#include <stdlib.h>
int lines;
%}

/* Rules */
%%
<<EOF>>			{ printf("!!!\n"); }
[0-9]+\.[0-9]+	{ printf("Floating Point: %s\n", yytext); }
[0-9]+			{ printf("Integer: %s\n", yytext); }
[a-zA-Z0-9]+	{ printf("String: %s\n", yytext); }
[ |\t]+			{ printf("PASS\n"); }
\n				{ printf("line %d finished.\n", ++lines); }
.   			;	// Emm...I need this.
%%

/* Subroutines  */
int main(int argc, char **argv){
	if (argc == 2) {
		FILE *file = fopen(argv[1], "r");
		if (!file) { perror(argv[1]); exit(-1); }
		yyin = (int)file;
	}

	yylex();
}
