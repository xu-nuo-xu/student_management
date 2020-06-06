#ifndef _GLOBALS_H_
#define _GLOBALS_H_
#endif
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
typedef enum { StmtK, ExpK }NodeKind;
typedef enum { IfK=0, AssignK, WhileK, CompK, VarDefK }StmtKind;
typedef enum { OpK=5, intNumK,realNumK, IdK, IntK, RealK }ExpKind;	//IntK,RealK指的是integer,reald(Type),intNumK,realNumK说明该节点是数字
#define MAXCHILDREN 5
typedef struct treeNode
{
	struct treeNode * child[MAXCHILDREN];	//当前节点孩子，根据语句不同而不同
	struct treeNode * sibling;	//当前节点兄弟，用于类似statment;statment;statment这种情况
	int lineno;			//当前节点行数
	NodeKind nodekind;	//说明是语句节点/表达式节点
	union { StmtKind stmt; ExpKind exp; } kind;	//语句节点/表达式节点具体形式
	union {
		int val;		//当前节点值(整数)
		double vald;		//实数
		char name[30];	//当前节点名称
	} attr;
	int PLACE;			//在符号表中的位置
	int quaternary_num;	//对应着第几个四元式
} TreeNode;