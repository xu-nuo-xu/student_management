// lexical_analysis_new.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include "pch.h"
#include "iostream"
#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "lexical_anaylsis.h"
#include "parse_analysis.h"
#include <algorithm>
#include "util.h"
using namespace std;
/*****************************保留字表***********************************/
static char reserveWord[13][20] = {
	"program","var","begin","end","while","do","if","then","integer","reald","of","array","else"	//种别码：1-13
};																							//种别码：13-20保留
/*****************************界符运算符表*******************************/
static char operatorOrDelimiter[33][10] = {													//种别码：21-43
	"=","(",")","+","-","*","/",";",",","[","]",	//21-31
	":",":=",">=",">","<","<=","<>",				//32-38
	"and","not","or","..","."						//39-43									//其中32-43号可能无法由一个char来判断，我放后两行
};
/******************************标识符表**********************************/
static char IDentifierTb[1000][50] = { "" };												//种别码：98表示int，99表示实数，100表示标识符
/******************************行号记录********************************/
int row_num = 1;
/***************************词法分析中的token识别记录*********************************/
struct token result_token[1000] = { 0 };
int result_count=0;
/**************************词法分析中记录当前声明的数组元素个数****************/
int array_num = 0;
/**************************词法分析中记录当前token是否为数组元素****************/
int array_element = 0;
/**************************数组声明信息表空闲序号****************/
int free_array_info = 0;
/**************************数组声明信息表****************/
struct array_info array_info[50] = { 0 };
/****************************语法分析中当前token指针***********************************/
int parse_point = 0;
/****************************语法分析中当前token行数***********************************/
int lineno = 0;
/******************************查找保留字********************************/
int searchReserve(char reserveWord[][20], char s[])
{
	for (int i = 0;i < 13;i++)
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
	char tempString[1000];	//程序最大1000个字符
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
		if (r[i] != '\t'&& r[i] != '\r')//非无用字符加载到tempString中,\n换行符暂时不去除，为了记录错误行号所用
		{
			tempString[count++] = r[i];
		}
	}
	tempString[count++] = '$';
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
	while (ch == '\n')
	{
		row_num++;		//行号+1
		ch = resourceProject[++pProject];	//向后移一位
	}
	if (IsLetter(resourceProject[pProject]))	//首字母为字母，则可能是保留字(含数组)/标识符
	{
		token[count++] = resourceProject[pProject];	//收集单词
		pProject++;
		while (IsLetter(resourceProject[pProject]) || IsDigit(resourceProject[pProject]) || resourceProject[pProject] == '[' || resourceProject[pProject] == ']' || resourceProject[pProject] == '.')
		{
			if (resourceProject[pProject] == ']')	//只能声明1-99个数组元素 , 两种情况 1.array[1..20] 2.array[1..5]	//两位/一位
			{
				char num[2];	//存放数组元素个数,最多两位数
				if (IsDigit(resourceProject[pProject - 2]) && resourceProject[pProject - 3] == '.' && resourceProject[pProject - 4] == '.')		//第一种声明情况: array[1..20]
				{
					num[0] = resourceProject[pProject - 2];
					num[1] = resourceProject[pProject - 1];
					array_num = atoi(num);
				}
				else if (IsDigit(resourceProject[pProject - 1]) && resourceProject[pProject - 2] == '.' && resourceProject[pProject - 3] == '.') //第二种声明情况: array[1..5]
				{
					num[0] = resourceProject[pProject - 1];
					num[1] = 0;
					array_num = atoi(num);
				}
				else
				{
					array_element = 1;	//是数组元素，而非声明
				}
				if (array_num != 0)	//说明进行了数组声明，我们如第二种情况:array[1..5]，我们要把array[0],array[1],array[2],array[3],array[4]都放入IDentifierTb中
				{
					int find_array_name = 1;	//重新找到数组名
					char array_name[20];
					int begin,end,i=0;		//记录数组名开始字符与结束字符下标
					while (IsLetter(resourceProject[pProject - find_array_name]) == false)	//找到数组名中最后一个字母
					{
						find_array_name++;
					}
					end = find_array_name;
					while (IsLetter(resourceProject[pProject - find_array_name]) == true)
					{
						find_array_name++;
					}
					begin = find_array_name - 1;
					while (begin >= end)
					{
						array_name[i++] = resourceProject[pProject - begin];
						begin--;
					}
					array_name[i] = '\0';	//array_name存放完毕，接下来三行在数组信息表中记录声明的数组信息
					strcpy(array_info[free_array_info].array_name, array_name);
					array_info[free_array_info].array_num = array_num;
					free_array_info++;
					array_num = 0;	//最后归零，为下次声明数组做准备
				}
				
			}
			token[count++] = resourceProject[pProject];		//如果后跟字母/数字/Iden[digit..digit](数组元素)，则还在同一token中
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
					syn = 98;
					break;
				}
				else if (IsDigit(resourceProject[pProject + 1]) && is_real == 0)	//实数情况
				{
					is_real = 1;
					syn = 99;
				}
				else if (resourceProject[pProject] == '.' && is_real == 1)	//考虑2.25.28这种出错处理
				{
					printf("Error:Match dot two times in a same digit!   row_num : %d\n ", row_num);
					exit(0);
				}
			}

			
			token[count++] = resourceProject[pProject];
			pProject++;
		}
		token[count] = '\0';
		if (syn != 99)	//若不是实数(种别码99)则是整数(种别码98)
		{
			syn = 98;
		}
		return;
	}
	else if (ch == '=' || ch == '(' || ch == ')' || ch == '+' || ch == '-' ||
		ch == '*' || ch == '/' || ch == ';' || ch == ',' || ch == '[' || ch == ']')	//若为运算符或者界符，则按顺序种别码为:21-40
	{
		token[0] = ch;
		token[1] = '\0';
		for (i = 0;i < 33;i++)
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
	else if (resourceProject[pProject] == '.')	//.
	{
		strcpy(token, ".");
		syn = 43;
		pProject ++;
	}
	else if (resourceProject[pProject] == EOF)	//结束符
	{
		syn = 0;
		strcpy(token, "$");
		return;
	}
	else
	{
		printf("Error:this character can't be identified : %c row_num: %d \n", ch, row_num);	//识别失败，错误处理
		exit(0);
	}

}
void array_indicate_check()		//数组下标检测
{
	int i, j = 0, array_num_element, k;
	char name[50] = { 0 };
	char number[3] = { 0 };
	if (result_token[result_count].array_element == 1)	//是数组元素
	{
		while (result_token[result_count].name[j] != '[')	//找到数组名
		{
			j++;
		}
		strncpy(name, result_token[result_count].name, j);
		if (IsDigit(result_token[result_count].name[j + 2]))	//两位数字
		{
			number[0] = result_token[result_count].name[j + 1];
			number[1] = result_token[result_count].name[j + 2];
		}
		else
		{
			number[0] = result_token[result_count].name[j + 1];	//一位数字
		}
		array_num_element = atoi(number);
		for (k = 0;k < free_array_info;k++)
		{
			if (strcmp(array_info[k].array_name, name) == 0)
			{
				if (array_num_element < array_info[k].array_num)
				{
					//printf("this array element is legal\n");	//合法情况可以不打印
				}
				else
				{
					printf("Error: you use an array element: %s\n", result_token[result_count].name);
					printf("This array element is illegal\nRow num : %d\n",result_token[result_count].row_num);
					exit(0);
				}
			}
		}
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
		cout << "Error: Can't open source code file!";
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
	filterResource(resourceProject, pProject);		//过滤无用字符
	pProject = 0;
	if ((fp1 = fopen("C:\\Users\\许诺\\Desktop\\token.txt", "w+")) == NULL)		//token写入文件
	{
		cout << "Error: Can't open token output file!";
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
		}
		if (syn == 0)break;
		result_token[result_count].type = syn;
		strcpy(result_token[result_count].name, token);
		result_token[result_count].row_num = row_num;
		if (array_element != 0)
		{
			result_token[result_count].array_element = 1;
			array_element = 0;
			array_indicate_check();		//当使用了数组元素之后，做一个IDentifierTb中数组是否有超过边界的检测
		}
		result_count++;
		printf("<%d,%s>\n", syn, token);
		fprintf(fp1, "<%d,%s>\n", syn, token);
	}
	fclose(fp1);
	//ProgDef();
	
	TreeNode * t = ProgDef();
	printTree(t);

	if (parse_point == result_count)	//推导结束后语法部分的指针应指向最后一个token
	{
		printf("this is a right program!\n");
	}
	else
	{
		wrong_sentence();
	}
	return 0;
}


