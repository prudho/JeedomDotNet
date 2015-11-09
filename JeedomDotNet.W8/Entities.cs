using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeedomDotNet.Entities;

namespace JeedomDotNet
{
    public class JeedomEntities
    {
        public Plugins Plugins { get { return _plugins; } }
        public Commands Commands { get { return _commands; } }
        public Messages Messages { get { return _messages; } }
        public EqLogics EqLogics { get { return _eqLogics; }}
        public Objects Objects { get { return _objects; } }

        public bool Loaded { get { return this._loaded; } }

        public string Error { get { return _error; } }

        private Plugins _plugins;
        private Commands _commands;
        private Messages _messages;
        private EqLogics _eqLogics;
        private Objects _objects;

        private Jeedom _jee;

        private bool _loaded;
        private string _error;

        public JeedomEntities(Jeedom jee)
        {
            _jee = jee;

            Refresh();
        }

        public void Refresh()
        {
            _objects = new Objects(_jee);

            if(_objects.Loaded)
            {
                _eqLogics = new EqLogics(_jee, this);

                if (_eqLogics.Loaded)
                {
                    _commands = new Commands(_jee, this);

                    if (_commands.Loaded)
                    {
                        _plugins = new Plugins(_jee);

                        if (_plugins.Loaded)
                        {
                            _messages = new Messages(_jee);

                            if (_messages.Loaded)
                            {
                                _loaded = true;
                            }
                            else
                            {
                                _error = _messages.Error;
                                _loaded = false;
                            }

                        }
                        else
                        {
                            _error = _plugins.Error;
                            _loaded = false;
                        }

                    }
                    else
                    {
                        _error = _commands.Error;
                        _loaded = false;
                    }
                }
                else
                {
                    _error = _eqLogics.Error;
                    _loaded = false;
                }
            }
            else
            {
                _error = _objects.Error;
                _loaded = false;
            }
        }
    }
}
