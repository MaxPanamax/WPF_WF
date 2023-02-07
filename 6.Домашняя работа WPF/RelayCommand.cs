using System;
using System.Windows.Input;
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
    #region Делегаты для методов WPF команд
    public delegate void ExecuteHandler(object parameter);
    public delegate bool CanExecuteHandler(object parameter);
    #endregion

    /// <summary>Класс реализующий интерфейс ICommand для создания WPF команд</summary>
    public class RelayCommand : ICommand
    {
        private readonly CanExecuteHandler _canExecute;
        private readonly ExecuteHandler _onExecute;

        /// <summary>Событие извещающее об измении состояния команды</summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>Конструктор команды</summary>
        /// <param name="execute">Выполняемый метод команды</param>
        /// <param name="canExecute">Метод разрешающий выполнение команды</param>
        public RelayCommand(ExecuteHandler execute, CanExecuteHandler canExecute = null)
        {
            this._onExecute = execute;
            this._canExecute = canExecute;
        }


        /// <summary>Вызов разрешающего метода команды</summary>
        /// <param name="parameter">Параметр команды</param>
        /// <returns>True - если выполнение команды разрешено</returns>
        public bool CanExecute(object parameter) => _canExecute == null ? true : _canExecute.Invoke(parameter);

        /// <summary>Вызов выполняющего метода команды</summary>
        /// <param name="parameter">Параметр команды</param>
        public void Execute(object parameter) => _onExecute?.Invoke(parameter);
    }
}
