using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

public class CustomMaterialButton : MaterialRaisedButton
{
    private Color? _customBackColor;
    private Color? _customTextColor;
    private float? _customFontSize;
    private string _customFontFamily;

    private System.Windows.Forms.Timer _rippleTimer;
    private Point? _clickLocation = null;
    private int _rippleRadius = 0;

    // Propiedades para el color y tamaño del texto
    public Color? CustomBackColor
    {
        get => _customBackColor;
        set
        {
            _customBackColor = value;
            Invalidate();
        }
    }

    public Color? CustomTextColor
    {
        get => _customTextColor;
        set
        {
            _customTextColor = value;
            Invalidate();
        }
    }

    public float? CustomFontSize
    {
        get => _customFontSize;
        set
        {
            _customFontSize = value;
            Invalidate();
        }
    }

    public string CustomFontFamily
    {
        get => _customFontFamily;
        set
        {
            _customFontFamily = value;
            Invalidate();
        }
    }

    // Constructor
    public void CustomMaterialFlatButton()
    {
        InitializeRippleTimer();
        this.AutoSize = false;
       
    }

    // Método para inicializar el temporizador
    private void InitializeRippleTimer()
    {
        if (_rippleTimer == null) // Validación explícita
        {
            _rippleTimer = new System.Windows.Forms.Timer
            {
                Interval = 2 // Controla la velocidad de la animación
            };
            _rippleTimer.Tick += RippleTimer_Tick;
        }
    }

    private void RippleTimer_Tick(object sender, EventArgs e)
    {
        _rippleRadius += 10; // Incrementar el radio
        if (_rippleRadius > Width + Height)
        {
            _rippleTimer.Stop();
            _rippleRadius = 0;
            _clickLocation = null;
        }
        Invalidate(); // Redibujar el control
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        // Asegurarse de que el temporizador esté inicializado antes de usarlo
        InitializeRippleTimer();

        // Iniciar la animación de clic
        _clickLocation = e.Location;
        _rippleRadius = 0;
        _rippleTimer.Start();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Dibujar el fondo personalizado
        if (_customBackColor.HasValue)
        {
            using (SolidBrush brush = new SolidBrush(_customBackColor.Value))
            {
                pevent.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        // Crear una fuente personalizada si el tamaño o la familia están definidos
        // Dibujar el texto con tamaño y color personalizados
        System.Drawing.Font customFont = _customFontSize.HasValue
            ? new System.Drawing.Font(Font.FontFamily, _customFontSize.Value)
            : Font;
        try
        {
            if (!string.IsNullOrEmpty(_customFontFamily) && _customFontSize.HasValue)
            {
                customFont = new System.Drawing.Font(_customFontFamily, _customFontSize.Value);
            }
            else if (_customFontSize.HasValue)
            {
                customFont = new System.Drawing.Font(Font.FontFamily, _customFontSize.Value);
            }
            else
            {
                customFont = Font;
            }
        }
        catch
        {
            customFont = Font; // Fallback si la fuente no es válida
        }
       

        if (_customTextColor.HasValue)
        {
            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                customFont,
                ClientRectangle,
                _customTextColor.Value,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        // Dibujar la animación de clic
        if (_clickLocation.HasValue)
        {
            using (SolidBrush rippleBrush = new SolidBrush(Color.FromArgb(50, Color.Black)))
            {
                pevent.Graphics.FillEllipse(
                    rippleBrush,
                    _clickLocation.Value.X - _rippleRadius,
                    _clickLocation.Value.Y - _rippleRadius,
                    _rippleRadius * 2,
                    _rippleRadius * 2
                );
            }
        }
    }
}

