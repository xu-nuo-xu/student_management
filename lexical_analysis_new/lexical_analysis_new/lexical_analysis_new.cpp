// lexical_analysis_new.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include "pch.h"
#include "iostream"
#include "stdio.h"
#include "stdlib.h"
#include "string.h"
using namespace std;
/*****************************保留字表***********************************/
static char reserveWord[12][20] = {
	"program","var","begin","end","while","do","if","then","integer","reald","of","array"	//种别码：1-12
};																							//种别码：13-20保留
/*****************************界符运算符表*******************************/
static char operatorOrDelimiter[32][10] = {													//种别码：21-42
	"=","(",")","+","-","*","/",";",",","[","]",	//21-31
	":",":=",">=",">","<","<=","<>",				//32-38
	"and","not","or",'..'							//39-42									//其中32-42号可能无法由一个char来判断，我放后两行
};
/******************************标识符表**,"[","]"	********************************/
static char IDentifierTb[1000][50] = { "" };												//种别码：98表示int，99表示实数，100表示标识符
/******************************查找保留字********************************/
int searchReserve(char reserveWord[][20], char s[])
{
	for (int i = 0;i < 12;i++)
	{
		if (strcmp(reserveWord[i], s) == 0)
		{
			return i + 1;	//保留字查找成功，返回相应种别码
		}
	}
	return -1;	//没找到说明是非保留字，即标识符
}
/******************************判断是否为字母*****************************/
bool IsLetter(char letter)
{
	if (letter >= 'a' && letter <= 'z' || letter >= 'A'&&letter <= 'Z' || letter == '_')
	{
		return true;
	}
	return false;
}
/*******************************判断是否为数字***************************/
bool IsDigit(char digit)
{
	if (digit >= '0'&&digit <= '9')
	{
		return true;
	}
	return false;
}
/***********************编译预处理，取出无用字符和注释************/
void filterResource(char r[], int pProject)
{
	char tempString[1000];	//程序最大10000个字符
	int count = 0;
	for (int i = 0;i < pProject;i++)
	{
		if (r[i] == '/'&&r[i + 1] == '/')	//单行注释处理
		{
			while (r[i] != '\n')
			{
				i++;
			}
		}
		if (r[i] != '\n'&& r[i] != '\t'&& r[i] != '\r')//非无用字符加载到tempString中
		{
			tempString[count++] = r[i];
		}
	}
	tempString[count] = '\0';
	strcpy(r, tempString);
}
/**********************分析子程序，算法核心****************/
void Scanner(int &syn, char resourceProject[], char token[], int &pProject)	//一次识别一个token
{
	int i, count = 0;
	char ch;
	ch = resourceProject[pProject];
	while (ch == ' ')	//跳过源程序空格
	{
		pProject++;
		ch = resourceProject[pProject];
	}
	for (i = 0;i < 30;i++);
	{
		token[i] = '\0';
	}
	if (IsLetter(resourceProject[pProject]))	//首字母为字母，则可能是保留字/标识符
	{
		token[count++] = resourceProject[pProject];	//收集单词
		pProject++;
		while (IsLetter(resourceProject[pProject]) || IsDigit(resourceProject[pProject]))	//如果后跟字母/数字，则还在同一token中
		{
			token[count++] = resourceProject[pProject];
			pProject++;
		}
		token[count] = '\0';	//跳出while，token收集完毕
		syn = searchReserve(reserveWord, token);
		if (syn == -1)	//若不是保留字则返回-1，即是标识符
		{
			syn = 100;
		}
		return;
	}
	else if (IsDigit(resourceProject[pProject]))	//首字母为数字，则可能是整数/实数/科学计数法表示的数字(暂时不写)/数组下标array[1..10]第一个整数
	{
		int is_real = 0;
		while (IsDigit(resourceProject[pProject]) || resourceProject[pProject] == '.')	//实数情况
		{
			/*if (resourceProject[pProject] == '.' && is_real == 0)	//实数判断
			{
				is_real = 1;
				syn = 98;
			}*/
			if (resourceProject[pProject] == '.')	//可能是实数，如1.548，可能是数组下标，如array[1..10]
			{
				if (resourceProject[pProject + 1] == '.')	//连续两个'.'说明是数组下标
				{
					syn == 99;
					break;
				}
				else if (IsDigit(resourceProject[pProject + 1]) && is_real == 0)	//实数情况
				{
					is_real = 1;
					syn = 98;
				}
			}

			else if (resourceProject[pProject] == '.' && is_real == 1)	//考虑2.25.28这种出错处理
			{
				printf("Error:Match dot two times in a same digit!\n");
				exit(0);
			}
			token[count++] = resourceProject[pProject];
			pProject++;
		}
		token[count] = '\0';
		if (syn != 98)	//若不是实数(种别码98)则是整数(种别码99)
		{
			syn = 99;
		}
		return;
	}
	else if (ch == '=' || ch == '(' || ch == ')' || ch == '+' || ch == '-' ||
		ch == '*' || ch == '/' || ch == ';' || ch == ',' || ch == '[' || ch == ']')	//若为运算符或者界符，则按顺序种别码为:21-40
	{
		token[0] = ch;
		token[1] = '\0';
		for (i = 0;i < 32;i++)
		{
			if (strcmp(token, operatorOrDelimiter[i]) == 0)
			{
				syn = i + 21;	//种别码从21号开始(21-31)
				break;
			}
		}
		pProject++;	//指针后移，为下一次扫描做准备
		return;
	}
	else if (resourceProject[pProject] == ':')	// : , :=
	{
		token[count++] = ':';	//先记录一个
		pProject++;
		if (resourceProject[pProject] == '=')	// :=
		{
			token[count++] = '=';
			syn = 34;
			pProject++;
		}
		else
		{
			syn = 33;	// :
		}
		token[count] = '\0';
		return;
	}
	else if (resourceProject[pProject] == '>')	// > , >=
	{
		token[count++] = '>';	//先记录一个
		pProject++;
		if (resourceProject[pProject] == '=')	// >=
		{
			token[count++] = '=';
			syn = 35;
			pProject++;
		}
		else
		{
			syn = 36;	// >
		}
		token[count] = '\0';
		return;
	}
	else if (resourceProject[pProject] == '<')	// < , <= ,<>
	{
		token[count++] = '<';	//先记录一个
		pProject++;
		if (resourceProject[pProject] == '=')	// <=
		{
			token[count++] = '=';
			syn = 38;
			pProject++;
		}
		else if (resourceProject[pProject] == '>')  //<>
		{
			token[count++] = '>';
			syn = 39;
			pProject++;
		}
		else
		{
			syn = 37;	// <
		}
		token[count] = '\0';
		return;
	}
	else if (resourceProject[pProject] == 'a')	//and
	{
		strcpy(token, "and");
		syn = 40;
		pProject += 3;
		return;
	}
	else if (resourceProject[pProject] == 'n')	//not
	{
		strcpy(token, "not");
		syn = 41;
		pProject += 3;
		return;
	}
	else if (resourceProject[pProject] == 'o')	//or
	{
		strcpy(token, "or");
		syn = 42;
		pProject += 2;
		return;
	}
	else if (resourceProject[pProject] == '.' && resourceProject[pProject+1] == '.')	//..
	{
		strcpy(token, "..");
		syn = 42;
		pProject += 2;
		return;
	}
	else if (resourceProject[pProject] == EOF)	//结束符
	{
		syn = 0;
		return;
	}
	else
	{
		printf("Error:this character can't be identified : %c \n", ch);	//识别失败，错误处理
		exit(0);
	}

}
int main()
{
	char resourceProject[1000] = {0};	//源程序
	char token[30] = { 0 };
	int syn = -1, i;
	int pProject = 0;	//程序指针
	FILE *fp, *fp1;
	if ((fp = fopen("C:\\Users\\许诺\\Desktop\\lexical_analysis.txt", "r")) == NULL)
	{
		cout << "Can't open source code file!";
		exit(0);
	}
	resourceProject[pProject] = fgetc(fp);

	while (resourceProject[pProject] != EOF)	//将源代码录入resourceProject中
	{
		pProject++;
		resourceProject[pProject] = fgetc(fp);
	}
	resourceProject[++pProject] = '\0';
	fclose(fp);
	cout << endl << "源程序为：" << endl;
	cout << resourceProject << endl;
	filterResource(resourceProject, pProject);
	pProject = 0;
	if ((fp1 = fopen("C:\\Users\\许诺\\Desktop\\token.txt", "w+")) == NULL)		//token写入文件
	{
		cout << "Can't open token output file!";
		exit(0);
	}
	while (syn != 0)
	{
		Scanner(syn, resourceProject, token, pProject);
		if (syn == 100)	//标识符
		{
			for (i = 0;i < 1000;i++)	//插入标识符
			{
				if (strcmp(IDentifierTb[i], token) == 0)	//表中存在该标识符
				{
					break;
				}
				else if (strcmp(IDentifierTb[i],"")==0)		//表中不存在，该位置目前是空，则将标识符插入表中
				{
					strcpy(IDentifierTb[i], token);
					break;
				}
			}
			printf("<Iden,%s>\n", token);
			fprintf(fp1, "<Iden,%s>\n", token);
		}
		else if (syn >= 1 && syn <= 12)	//保留字
		{
			printf("<reserveword,%s>\n", reserveWord[syn - 1]);
			fprintf(fp1, "<reserveword,%s>\n", reserveWord[syn - 1]);
		}
		else if (syn == 98)	//实数
		{
			printf("<RealNo,%s>\n", token);
			fprintf(fp1, "<RealNo,%s>\n", token);
		}
		else if (syn == 99)	//整数
		{
			printf("<IntNo,%s>\n", token);
			fprintf(fp1, "<IntNo,%s>\n", token);
		}
		else if (syn >= 21 && syn <= 42)	//算符或者界符
		{
			printf("<operatorOrDelimiter,%s>\n", token);
			fprintf(fp1, "<operatorOrDelimiter,%s>\n", token);
		}
	}

	fclose(fp1);
	return 0;
}

