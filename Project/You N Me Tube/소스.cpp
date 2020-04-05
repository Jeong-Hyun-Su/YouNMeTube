#include "std_lib_facilities.h"
struct node {
	int data;
	struct node *next;
	struct node *prev;
};

void addnode(struct node *top, int data) {
	struct node *newnode = new node;
	newnode->next = top->next;
	newnode->data = data;
	top->next = newnode;
}

void delnode(struct node *top) {
	struct node *delnode = new node;
	top->next = delnode->next;

	free(delnode);
}
int main()
{
	struct node *head = new node;

	struct node *node1 = new node;
}
