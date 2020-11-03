import json, random
import pycountry
import argparse

COUNTRY = [x.name for x in list(pycountry.countries)]
last_id = 0


class Model:
    def __init__(self, kwargs):
        global last_id
        type = kwargs['type']
        range_int_min = kwargs['range_int_min']
        range_int_max = kwargs['range_int_max']
        self.id = last_id + 1
        last_id += 1
        self.type = random.choice(type)
        self.power = random.randint(range_int_min, range_int_max)
        self.country = random.choice(COUNTRY)
        if self.type in ('Bus', 'Train'):
            self.c_people = random.randint(range_int_min, range_int_max)
        else:
            self.c_lifting = random.randint(range_int_min, range_int_max)
        self.c_fuel = random.randint(range_int_min, range_int_max)

    def gen_dict(self):
        _dict = {
            'id': self.id,
            'type': self.type,
            'power': self.power,
            'country': self.country,
        }
        if self.type in ('Bus', 'Train'):
            _dict.update({
                'c_people': self.c_people
            })
        else:
            _dict.update({
                'c_lifting': self.c_lifting
            })
        _dict.update({'c_fuel': self.c_fuel})
        return _dict


def create_json(kwargs):
    a = [Model(kwargs) for x in range(kwargs['count'])]
    mas = []
    for el in a:
        mas.append(el.gen_dict())
    j = json.dumps(mas)
    with open('1.json', 'w') as f:
        f.write(j)


# --type Train,Bus --range_int_min -10 --range_int_max 100 --count 100
if __name__ == '__main__':
    parser = argparse.ArgumentParser(description='A tutorial of argparse!')
    parser.add_argument("--type", type=str)
    parser.add_argument("--range_int_min", type=int)
    parser.add_argument("--range_int_max", type=int)

    parser.add_argument("--count", type=int)

    args = parser.parse_args()

    create_json({
        'type': args.type.split(','),
        'range_int_min': args.range_int_min,
        'range_int_max': args.range_int_max,
        'count': args.count,
    })
