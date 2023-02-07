using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
//Правила игры
//В каждом раунде появляется плитка номинала «2» (с вероятностью 90 %) или «4» (с вероятностью 10 %)
//Нажатием стрелки игрок может скинуть все плитки игрового поля в одну из 4 сторон. Если при сбрасывании
//две плитки одного номинала «налетают» одна на другую, то они превращаются в одну, номинал которой равен
//сумме соединившихся плиток. После каждого хода на свободной секции поля появляется новая плитка номиналом
//«2» или «4». Если при нажатии кнопки местоположение плиток или их номинал не изменится, то ход не совершается.
//Если в одной строчке или в одном столбце находится более двух плиток одного номинала, то при сбрасывании
//они начинают соединяться с той стороны, в которую были направлены. Например, находящиеся в одной строке
//плитки (4, 4, 4) после хода влево превратятся в (8, 4), а после хода вправо — в (4, 8).
//Данная обработка неоднозначности позволяет более точно формировать стратегию игры.
//За каждое соединение игровые очки увеличиваются на номинал получившейся плитки.
//Игра заканчивается поражением, если после очередного хода невозможно совершить действие.

namespace Ponomarenko_Game2048
{
    /// <summary>Класс ViewModel для игры 2048</summary>
    public class ViewModel2048 : OnPropertyChangedClass
    {

        Model2048 model;
        private IEnumerable<Cell> _cells;

        /// <summary>Общий построчный набор ячеек</summary>
        public IEnumerable<Cell> Cells { get => _cells; private set { _cells = value; OnPropertyChanged(null); } }

        /// <summary>Количество пустых ячеек</summary>
        public int CountEmptyCell => model.CountEmptyCell;

        /// <summary>Игра закончена</summary>
        public bool IsGameOver => model.IsGameOver;

        /// <summary>Ячейка с максимальным значением</summary>
        public int MaxValue => model.MaxValue;

        /// <summary>Сумма значений всех ячеек</summary>
        public int SumValue => model.SumValue;

        /// <summary>Следующий шаг (раунд) -  сдвиг в задданом направлени</summary>
        /// <param name="direction"></param>
        public void NextStep(DirectionEnum direction)
        {
            if (IsGameOver)
                return;

            model.Step(direction);
        }

        List<string> modelProperties = new List<string>() { nameof(Model2048.CountEmptyCell), nameof(Model2048.IsGameOver), nameof(Model2048.MaxValue), nameof(Model2048.SumValue) };
        private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            string propertyName = e.PropertyName;
            if (string.IsNullOrEmpty(propertyName) || modelProperties.IndexOf(propertyName) >= 0)
                OnPropertyChanged(propertyName);
        }

        /// <summary>Безпараметричесий конструтор</summary>
        public ViewModel2048()
        {
            RestartCommand = new RelayCommand(par => ReStart());
            ReStart();
        }

        /// <summary>Создание новой игры</summary>
        private void ReStart()
        {
            if (model != null)
                model.PropertyChanged -= Model_PropertyChanged;
            model = new Model2048();
            model.PropertyChanged += Model_PropertyChanged;
            List<Cell> cells = new List<Cell>();
            foreach (ImmutableArray<Cell> rowCells in model.GetCells())
                foreach (Cell cell in rowCells)
                    cells.Add(cell);
            Cells = cells;
            NextStep(DirectionEnum.None);
            NextStep(DirectionEnum.None);
        }

        /// <summary>Команда для создания новой игры</summary>
        public RelayCommand RestartCommand { get; }
    }
}
