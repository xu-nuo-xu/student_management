#pragma once
struct token {
	int type;	//种别码
	char name[10];	//内容
	int row_num;
	int array_element;	//是否为数组元素
};
extern int parse_point;		//指向当前识别的result_token
extern int array_num;		//专为array变量设置
extern int array_element;	//是否为数组元素
struct array_info			//数组声明信息表
{		
	char array_name[50];
	int array_num;
};
extern int free_array_info;	//数组声明信息表空闲序号
extern int lineno;