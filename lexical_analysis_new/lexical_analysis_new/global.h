#ifndef _GLOBALS_H_
#define _GLOBALS_H_
#endif
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
typedef enum { StmtK, ExpK }NodeKind;
typedef enum { IfK, AssignK, WhileK, CompK }StmtKind;
typedef enum { OpK, NumK, IdK }ExpKind;
#define MAXCHILDREN 5
typedef struct treeNode
{
	struct treeNode * child[MAXCHILDREN];	//��ǰ�ڵ㺢�ӣ�������䲻ͬ����ͬ
	struct treeNode * sibling;	//��ǰ�ڵ��ֵܣ���������statment;statment;statment�������
	int lineno;			//��ǰ�ڵ�����
	NodeKind nodekind;	//˵�������ڵ�/���ʽ�ڵ�
	union { StmtKind stmt; ExpKind exp; } kind;	//���ڵ�/���ʽ�ڵ������ʽ
	union {
		int val;		//��ǰ�ڵ�ֵ
		char name[20];	//��ǰ�ڵ�����
	} attr;
} TreeNode;