/*
 *	Illustration of buffer overflow, try with GDB!
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int check(char *password) {
	int auth_flag = 0;
	char password_buffer[7] = { 'K' };
	
	strcpy(password_buffer, password);
	
	if (strcmp(password_buffer, "cheer!") == 0) auth_flag = 1;

	return auth_flag;
}

int main(int argc, char *argv[]) {
	if (argc < 2) { printf("Usage: %s <password>\n", argv[0]); exit(0); }
	if (check(argv[1])) printf("\n\tAccess Granted.\n\n");
	else printf("\n\tAccess Denied.\n\n");
	return 0;
}
