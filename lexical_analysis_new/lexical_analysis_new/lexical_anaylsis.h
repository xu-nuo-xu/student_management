#pragma once
struct token {
	int type;	//种别码
	char name[10];	//内容
	int row_num;
};
extern int parse_point;		//指向当前识别的result_token