﻿global using OoplesFinance.StockIndicators.Helpers;

namespace OoplesFinance.StockIndicators.Enums;

public enum IndicatorName
{
    None,
    [Category(IndicatorType.Trend)]
    _1LCLeastSquaresMovingAverage,
    [Category(IndicatorType.Trend)]
    _3HMA,
    [Category(IndicatorType.Momentum)]
    _4MovingAverageConvergenceDivergence,
    [Category(IndicatorType.Momentum)]
    _4PercentagePriceOscillator,
    [Category(IndicatorType.Momentum)]
    AbsolutePriceOscillator,
    [Category(IndicatorType.Momentum)]
    AbsoluteStrengthIndex,
    [Category(IndicatorType.Trend)]
    AbsoluteStrengthMTFIndicator,
    [Category(IndicatorType.Momentum)]
    AcceleratorOscillator,
    [Category(IndicatorType.Volume)]
    AccumulationDistributionLine,
    [Category(IndicatorType.Momentum)]
    AccumulativeSwingIndex,
    [Category(IndicatorType.Trend)]
    AdaptiveAutonomousRecursiveMovingAverage,
    [Category(IndicatorType.Trend)]
    AdaptiveAutonomousRecursiveTrailingStop,
    [Category(IndicatorType.Momentum)]
    AdaptiveErgodicCandlestickOscillator,
    [Category(IndicatorType.Trend)]
    AdaptiveExponentialMovingAverage,
    [Category(IndicatorType.Trend)]
    AdaptiveLeastSquares,
    [Category(IndicatorType.Trend)]
    AdaptiveMovingAverage,
    [Category(IndicatorType.Volatility)]
    AdaptivePriceZoneIndicator,
    [Category(IndicatorType.Momentum)]
    AdaptiveRelativeStrengthIndex,
    [Category(IndicatorType.Momentum)]
    AdaptiveStochastic,
    [Category(IndicatorType.Trend)]
    AdaptiveTrailingStop,
    [Category(IndicatorType.Trend)]
    AhrensMovingAverage,
    [Category(IndicatorType.Trend)]
    AlligatorIndex,
    [Category(IndicatorType.Trend)]
    AlphaDecreasingExponentialMovingAverage,
    [Category(IndicatorType.Momentum)]
    AnchoredMomentum,
    [Category(IndicatorType.Momentum)]
    ApirineSlowRelativeStrengthIndex,
    [Category(IndicatorType.Trend)]
    ArnaudLegouxMovingAverage,
    [Category(IndicatorType.Trend)]
    AroonOscillator,
    [Category(IndicatorType.Momentum)]
    AsymmetricalRelativeStrengthIndex,
    [Category(IndicatorType.Trend)]
    AtrFilteredExponentialMovingAverage,
    [Category(IndicatorType.Volatility)]
    AutoDispersionBands,
    [Category(IndicatorType.Trend)]
    AutoFilter,
    [Category(IndicatorType.Trend)]
    AutoLine,
    [Category(IndicatorType.Trend)]
    AutoLineWithDrift,
    [Category(IndicatorType.Trend)]
    AutonomousRecursiveMovingAverage,
    [Category(IndicatorType.Momentum)]
    AverageAbsoluteErrorNormalization,
    [Category(IndicatorType.Trend)]
    AverageDirectionalIndex,
    [Category(IndicatorType.Momentum)]
    AverageMoneyFlowOscillator,
    [Category(IndicatorType.Volatility)]
    AverageTrueRange,
    [Category(IndicatorType.Volatility)]
    AverageTrueRangeChannel,
    [Category(IndicatorType.Trend)]
    AverageTrueRangeTrailingStops,
    [Category(IndicatorType.Momentum)]
    AwesomeOscillator,
    [Category(IndicatorType.Momentum)]
    BalanceOfPower,
    [Category(IndicatorType.Momentum)]
    BayesianOscillator,
    [Category(IndicatorType.Momentum)]
    BearPowerIndicator,
    [Category(IndicatorType.Momentum)]
    BelkhayateTiming,
    [Category(IndicatorType.Volume)]
    BetterVolumeIndicator,
    [Category(IndicatorType.Trend)]
    BilateralStochasticOscillator,
    [Category(IndicatorType.Volatility)]
    BollingerBands,
    [Category(IndicatorType.Volatility)]
    BollingerBandsAverageTrueRange,
    [Category(IndicatorType.Volatility)]
    BollingerBandsFibonacciRatios,
    [Category(IndicatorType.Momentum)]
    BollingerBandsPercentB,
    [Category(IndicatorType.Volatility)]
    BollingerBandsWidth,
    [Category(IndicatorType.Volatility)]
    BollingerBandsWithAtrPct,
    [Category(IndicatorType.Momentum)]
    BreakoutRelativeStrengthIndex,
    [Category(IndicatorType.Trend)]
    BryantAdaptiveMovingAverage,
    [Category(IndicatorType.Trend)]
    BuffAverage,
    [Category(IndicatorType.Momentum)]
    BullPowerIndicator,
    [Category(IndicatorType.Volatility)]
    CalmarRatio,
    [Category(IndicatorType.SupportAndResistance)]
    CamarillaPivotPoints,
    [Category(IndicatorType.Momentum)]
    CCTStochRelativeStrengthIndex,
    [Category(IndicatorType.Momentum)]
    CenterOfLinearity,
    [Category(IndicatorType.Volume)]
    ChaikinMoneyFlow,
    [Category(IndicatorType.Volume)]
    ChaikinOscillator,
    [Category(IndicatorType.Volatility)]
    ChaikinVolatility,
    [Category(IndicatorType.Momentum)]
    ChandeCompositeMomentumIndex,
    [Category(IndicatorType.Momentum)]
    ChandeForecastOscillator,
    [Category(IndicatorType.Momentum)]
    ChandeIntradayMomentumIndex,
    [Category(IndicatorType.Momentum)]
    ChandeKrollRSquaredIndex,
    [Category(IndicatorType.Momentum)]
    ChandeMomentumOscillator,
    [Category(IndicatorType.Momentum)]
    ChandeMomentumOscillatorAbsolute,
    [Category(IndicatorType.Momentum)]
    ChandeMomentumOscillatorAbsoluteAverage,
    [Category(IndicatorType.Momentum)]
    ChandeMomentumOscillatorAverage,
    [Category(IndicatorType.Momentum)]
    ChandeMomentumOscillatorAverageDisparityIndex,
    [Category(IndicatorType.Momentum)]
    ChandeMomentumOscillatorFilter,
    [Category(IndicatorType.Momentum)]
    ChandeQuickStick,
    [Category(IndicatorType.Trend)]
    ChandeTrendScore,
    [Category(IndicatorType.Trend)]
    ChandeVolatilityIndexDynamicAverageIndicator,
    [Category(IndicatorType.Trend)]
    ChandelierExit,
    [Category(IndicatorType.Momentum)]
    ChartmillValueIndicator,
    [Category(IndicatorType.Trend)]
    ChopZone,
    [Category(IndicatorType.Momentum)]
    ChoppinessIndex,
    [Category(IndicatorType.Volatility)]
    ClosedFormDistanceVolatility,
    [Category(IndicatorType.Momentum)]
    CommodityChannelIndex,
    [Category(IndicatorType.Volatility)]
    CommoditySelectionIndex,
    [Category(IndicatorType.Momentum)]
    ComparePriceMomentumOscillator,
    [Category(IndicatorType.Trend)]
    CompoundRatioMovingAverage,
    [Category(IndicatorType.Trend)]
    ConditionalAccumulator,
    [Category(IndicatorType.Momentum)]
    ConfluenceIndicator,
    [Category(IndicatorType.Momentum)]
    ConnorsRelativeStrengthIndex,
    [Category(IndicatorType.Momentum)]
    ConstanceBrownCompositeIndex,
    [Category(IndicatorType.SupportAndResistance)]
    ContractHighLow,
    [Category(IndicatorType.Momentum)]
    CoppockCurve,
    [Category(IndicatorType.Trend)]
    CoralTrendIndicator,
    [Category(IndicatorType.Trend)]
    CorrectedMovingAverage,
    [Category(IndicatorType.Trend)]
    CubedWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    DetrendedPriceOscillator,
    [Category(IndicatorType.SupportAndResistance)]
    DonchianChannels,
    [Category(IndicatorType.Trend)]
    DoubleExponentialMovingAverage,
    [Category(IndicatorType.Volume)]
    EaseOfMovement,
    [Category(IndicatorType.Trend)]
    EhlersMotherOfAdaptiveMovingAverages,
    [Category(IndicatorType.Trend)]
    EhlersPhaseCalculation,
    [Category(IndicatorType.Momentum)]
    EhlersRoofingFilter,
    [Category(IndicatorType.Trend)]
    ElderRayIndex,
    [Category(IndicatorType.Trend)]
    EndPointMovingAverage,
    [Category(IndicatorType.Trend)]
    ExponentialMovingAverage,
    [Category(IndicatorType.Trend)]
    FallingRisingFilter,
    [Category(IndicatorType.Trend)]
    FareySequenceWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    FastandSlowKurtosisOscillator,
    [Category(IndicatorType.Momentum)]
    FastandSlowRelativeStrengthIndexOscillator,
    [Category(IndicatorType.Momentum)]
    FastandSlowStochasticOscillator,
    [Category(IndicatorType.Momentum)]
    FastSlowDegreeOscillator,
    [Category(IndicatorType.Momentum)]
    FastZScore,
    [Category(IndicatorType.Momentum)]
    FearAndGreedIndicator,
    [Category(IndicatorType.SupportAndResistance)]
    FibonacciPivotPoints,
    [Category(IndicatorType.SupportAndResistance)]
    FibonacciRetrace,
    [Category(IndicatorType.Trend)]
    FibonacciWeightedMovingAverage,
    [Category(IndicatorType.Volume)]
    FiniteVolumeElements,
    [Category(IndicatorType.Volatility)]
    FireflyOscillator,
    [Category(IndicatorType.Trend)]
    FisherLeastSquaresMovingAverage,
    [Category(IndicatorType.Momentum)]
    FisherTransformStochasticOscillator,
    [Category(IndicatorType.SupportAndResistance)]
    FlaggingBands,
    [Category(IndicatorType.SupportAndResistance)]
    FloorPivotPoints,
    [Category(IndicatorType.Momentum)]
    FoldedRelativeStrengthIndex,
    [Category(IndicatorType.Volume)]
    ForceIndex,
    [Category(IndicatorType.Momentum)]
    ForecastOscillator,
    [Category(IndicatorType.Trend)]
    FractalAdaptiveMovingAverage,
    [Category(IndicatorType.Volatility)]
    FractalChaosBands,
    [Category(IndicatorType.Momentum)]
    FractalChaosOscillator,
    [Category(IndicatorType.Volume)]
    FreedomOfMovement,
    [Category(IndicatorType.Trend)]
    FullTypicalPrice,
    [Category(IndicatorType.Momentum)]
    FunctionToCandles,
    [Category(IndicatorType.Momentum)]
    FXSniperIndicator,
    [Category(IndicatorType.SupportAndResistance)]
    GChannels,
    [Category(IndicatorType.Momentum)]
    GOscillator,
    [Category(IndicatorType.Momentum)]
    GainLossMovingAverage,
    [Category(IndicatorType.Trend)]
    GannHiLoActivator,
    [Category(IndicatorType.Momentum)]
    GannSwingOscillator,
    [Category(IndicatorType.Momentum)]
    GannTrendOscillator,
    [Category(IndicatorType.Volatility)]
    GarmanKlassVolatility,
    [Category(IndicatorType.Momentum)]
    GatorOscillator,
    [Category(IndicatorType.Trend)]
    GeneralFilterEstimator,
    [Category(IndicatorType.Trend)]
    GeneralizedDoubleExponentialMovingAverage,
    [Category(IndicatorType.Volatility)]
    GopalakrishnanRangeIndex,
    [Category(IndicatorType.Trend)]
    GrandTrendForecasting,
    [Category(IndicatorType.Trend)]
    GroverLlorensActivator,
    [Category(IndicatorType.Cycle)]
    GroverLlorensCycleOscillator,
    [Category(IndicatorType.Trend)]
    GuppyCountBackLine,
    [Category(IndicatorType.Trend)]
    GuppyDistanceIndicator,
    [Category(IndicatorType.Momentum)]
    GuppyMultipleMovingAverage,
    [Category(IndicatorType.Trend)]
    HalfTrend,
    [Category(IndicatorType.Trend)]
    HampelFilter,
    [Category(IndicatorType.Volume)]
    HawkeyeVolumeIndicator,
    [Category(IndicatorType.Trend)]
    HendersonWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    HerrickPayoffIndex,
    [Category(IndicatorType.SupportAndResistance)]
    HighLowBands,
    [Category(IndicatorType.Momentum)]
    HighLowIndex,
    [Category(IndicatorType.SupportAndResistance)]
    HighLowMovingAverage,
    [Category(IndicatorType.SupportAndResistance)]
    HirashimaSugitaRS,
    [Category(IndicatorType.Volatility)]
    HistoricalVolatility,
    [Category(IndicatorType.Volatility)]
    HistoricalVolatilityPercentile,
    [Category(IndicatorType.Trend)]
    HoltExponentialMovingAverage,
    [Category(IndicatorType.Trend)]
    HullEstimate,
    [Category(IndicatorType.Trend)]
    HullMovingAverage,
    [Category(IndicatorType.SupportAndResistance)]
    HurstBands,
    [Category(IndicatorType.Cycle)]
    HurstCycleChannel,
    [Category(IndicatorType.Trend)]
    HybridConvolutionFilter,
    [Category(IndicatorType.Trend)]
    IchimokuCloud,
    [Category(IndicatorType.Trend)]
    IIRLeastSquaresEstimate,
    [Category(IndicatorType.Momentum)]
    ImpulseMovingAverageConvergenceDivergence,
    [Category(IndicatorType.Momentum)]
    ImpulsePercentagePriceOscillator,
    [Category(IndicatorType.Momentum)]
    InertiaIndicator,
    [Category(IndicatorType.Volatility)]
    InformationRatio,
    [Category(IndicatorType.Trend)]
    InsyncIndex,
    [Category(IndicatorType.Momentum)]
    InternalBarStrengthIndicator,
    [Category(IndicatorType.Volatility)]
    InterquartileRangeBands,
    [Category(IndicatorType.Trend)]
    InverseDistanceWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    InverseFisherFastZScore,
    [Category(IndicatorType.Momentum)]
    InverseFisherZScore,
    [Category(IndicatorType.Momentum)]
    JapaneseCorrelationCoefficient,
    [Category(IndicatorType.Momentum)]
    JmaRsxClone,
    [Category(IndicatorType.Volatility)]
    JrcFractalDimension,
    [Category(IndicatorType.Trend)]
    JsaMovingAverage,
    [Category(IndicatorType.Trend)]
    JurikMovingAverage,
    [Category(IndicatorType.Trend)]
    KalmanSmoother,
    [Category(IndicatorType.Momentum)]
    KarobeinOscillator,
    [Category(IndicatorType.Momentum)]
    KaseConvergenceDivergence,
    [Category(IndicatorType.SupportAndResistance)]
    KaseDevStopV1,
    [Category(IndicatorType.SupportAndResistance)]
    KaseDevStopV2,
    [Category(IndicatorType.Volume)]
    KaseIndicator,
    [Category(IndicatorType.Momentum)]
    KasePeakOscillatorV1,
    [Category(IndicatorType.Momentum)]
    KasePeakOscillatorV2,
    [Category(IndicatorType.Volatility)]
    KaseSerialDependencyIndex,
    [Category(IndicatorType.Volatility)]
    KaufmanAdaptiveBands,
    [Category(IndicatorType.Momentum)]
    KaufmanAdaptiveCorrelationOscillator,
    [Category(IndicatorType.Trend)]
    KaufmanAdaptiveLeastSquaresMovingAverage,
    [Category(IndicatorType.Trend)]
    KaufmanAdaptiveMovingAverage,
    [Category(IndicatorType.Momentum)]
    KaufmanBinaryWave,
    [Category(IndicatorType.Momentum)]
    KaufmanStressIndicator,
    [Category(IndicatorType.Volatility)]
    KeltnerChannels,
    [Category(IndicatorType.Volatility)]
    KendallRankCorrelationCoefficient,
    [Category(IndicatorType.Volatility)]
    KirshenbaumBands,
    [Category(IndicatorType.Volume)]
    KlingerVolumeOscillator,
    [Category(IndicatorType.Momentum)]
    KnowSureThing,
    [Category(IndicatorType.Momentum)]
    KurtosisIndicator,
    [Category(IndicatorType.Momentum)]
    KwanIndicator,
    [Category(IndicatorType.SupportAndResistance)]
    LBRPaintBars,
    [Category(IndicatorType.Trend)]
    LeastSquaresMovingAverage,
    [Category(IndicatorType.Trend)]
    LeoMovingAverage,
    [Category(IndicatorType.Trend)]
    LightLeastSquaresMovingAverage,
    [Category(IndicatorType.Momentum)]
    LindaRaschke3_10Oscillator,
    [Category(IndicatorType.SupportAndResistance)]
    LinearChannels,
    [Category(IndicatorType.Trend)]
    LinearExtrapolation,
    [Category(IndicatorType.Momentum)]
    LinearQuadraticConvergenceDivergenceOscillator,
    [Category(IndicatorType.Trend)]
    LinearRegression,
    [Category(IndicatorType.Trend)]
    LinearRegressionLine,
    [Category(IndicatorType.Trend)]
    LinearTrailingStop,
    [Category(IndicatorType.Trend)]
    LinearWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    LiquidRelativeStrengthIndex,
    [Category(IndicatorType.Momentum)]
    LogisticCorrelation,
    [Category(IndicatorType.Momentum)]
    McClellanOscillator,
    [Category(IndicatorType.Trend)]
    McNichollMovingAverage,
    [Category(IndicatorType.Trend)]
    MedianPrice,
    [Category(IndicatorType.Volume)]
    MoneyFlowIndex,
    [Category(IndicatorType.SupportAndResistance)]
    MovingAverageChannel,
    [Category(IndicatorType.Momentum)]
    MovingAverageConvergenceDivergence,
    [Category(IndicatorType.Momentum)]
    MovingAverageConvergenceDivergenceLeader,
    [Category(IndicatorType.SupportAndResistance)]
    MovingAverageEnvelope,
    [Category(IndicatorType.Momentum)]
    NarrowBandpassFilter,
    [Category(IndicatorType.Volatility)]
    NarrowSidewaysChannel,
    [Category(IndicatorType.Momentum)]
    NaturalDirectionalCombo,
    [Category(IndicatorType.Momentum)]
    NaturalDirectionalIndex,
    [Category(IndicatorType.Momentum)]
    NaturalMarketCombo,
    [Category(IndicatorType.Momentum)]
    NaturalMarketMirror,
    [Category(IndicatorType.Momentum)]
    NaturalMarketRiver,
    [Category(IndicatorType.Momentum)]
    NaturalMarketSlope,
    [Category(IndicatorType.Trend)]
    NaturalMovingAverage,
    [Category(IndicatorType.Momentum)]
    NaturalStochasticIndicator,
    [Category(IndicatorType.Volume)]
    NegativeVolumeDisparityIndicator,
    [Category(IndicatorType.Volume)]
    NegativeVolumeIndex,
    [Category(IndicatorType.Trend)]
    NickRypockTrailingReverse,
    [Category(IndicatorType.Momentum)]
    NormalizedRelativeVigorIndex,
    [Category(IndicatorType.Momentum)]
    NthOrderDifferencingOscillator,
    [Category(IndicatorType.Momentum)]
    OCHistogram,
    [Category(IndicatorType.Momentum)]
    OceanIndicator,
    [Category(IndicatorType.Volatility)]
    OmegaRatio,
    [Category(IndicatorType.Volume)]
    OnBalanceVolume,
    [Category(IndicatorType.Volume)]
    OnBalanceVolumeDisparityIndicator,
    [Category(IndicatorType.Volume)]
    OnBalanceVolumeModified,
    [Category(IndicatorType.Volume)]
    OnBalanceVolumeReflex,
    [Category(IndicatorType.Trend)]
    OptimalWeightedMovingAverage,
    [Category(IndicatorType.Trend)]
    OptimizedTrendTracker,
    [Category(IndicatorType.Momentum)]
    OscOscillator,
    [Category(IndicatorType.Momentum)]
    OscarIndicator,
    [Category(IndicatorType.Trend)]
    OvershootReductionMovingAverage,
    [Category(IndicatorType.Trend)]
    ParabolicSAR,
    [Category(IndicatorType.Trend)]
    ParabolicWeightedMovingAverage,
    [Category(IndicatorType.Trend)]
    ParametricCorrectiveLinearMovingAverage,
    [Category(IndicatorType.Trend)]
    ParametricKalmanFilter,
    [Category(IndicatorType.Trend)]
    PeakValleyEstimation,
    [Category(IndicatorType.Trend)]
    PentupleExponentialMovingAverage,
    [Category(IndicatorType.Momentum)]
    PercentChangeOscillator,
    [Category(IndicatorType.Momentum)]
    PercentagePriceOscillator,
    [Category(IndicatorType.Momentum)]
    PercentageVolumeOscillator,
    [Category(IndicatorType.Momentum)]
    PercentagePriceOscillatorLeader,
    [Category(IndicatorType.SupportAndResistance)]
    PercentageTrailingStops,
    [Category(IndicatorType.Trend)]
    PercentageTrend,
    [Category(IndicatorType.Momentum)]
    PerformanceIndex,
    [Category(IndicatorType.SupportAndResistance)]
    PeriodicChannel,
    [Category(IndicatorType.Momentum)]
    PhaseChangeIndex,
    [Category(IndicatorType.Momentum)]
    PivotDetectorOscillator,
    [Category(IndicatorType.Trend)]
    PivotPointAverage,
    [Category(IndicatorType.Momentum)]
    PolarizedFractalEfficiency,
    [Category(IndicatorType.Trend)]
    PolynomialLeastSquaresMovingAverage,
    [Category(IndicatorType.Volume)]
    PositiveVolumeIndex,
    [Category(IndicatorType.Trend)]
    PoweredKaufmanAdaptiveMovingAverage,
    [Category(IndicatorType.Momentum)]
    PremierStochasticOscillator,
    [Category(IndicatorType.Momentum)]
    PrettyGoodOscillator,
    [Category(IndicatorType.SupportAndResistance)]
    PriceChannel,
    [Category(IndicatorType.Volatility)]
    PriceCurveChannel,
    [Category(IndicatorType.Momentum)]
    PriceCycleOscillator,
    [Category(IndicatorType.Volatility)]
    PriceHeadleyAccelerationBands,
    [Category(IndicatorType.Volatility)]
    PriceLineChannel,
    [Category(IndicatorType.Momentum)]
    PriceMomentumOscillator,
    [Category(IndicatorType.Volume)]
    PriceVolumeOscillator,
    [Category(IndicatorType.Volume)]
    PriceVolumeRank,
    [Category(IndicatorType.Volume)]
    PriceVolumeTrend,
    [Category(IndicatorType.Momentum)]
    PriceZoneOscillator,
    [Category(IndicatorType.Volatility)]
    PrimeNumberBands,
    [Category(IndicatorType.Momentum)]
    PrimeNumberOscillator,
    [Category(IndicatorType.Momentum)]
    PringSpecialK,
    [Category(IndicatorType.SupportAndResistance)]
    ProjectedSupportAndResistance,
    [Category(IndicatorType.Volatility)]
    ProjectionBands,
    [Category(IndicatorType.Momentum)]
    ProjectionBandwidth,
    [Category(IndicatorType.Momentum)]
    ProjectionOscillator,
    [Category(IndicatorType.Volatility)]
    PseudoPolynomialChannel,
    [Category(IndicatorType.Momentum)]
    PsychologicalLine,
    [Category(IndicatorType.Volatility)]
    QmaSmaDifference,
    [Category(IndicatorType.Trend)]
    QuadraticLeastSquaresMovingAverage,
    [Category(IndicatorType.Trend)]
    QuadraticMovingAverage,
    [Category(IndicatorType.Trend)]
    QuadraticRegression,
    [Category(IndicatorType.Trend)]
    QuadrupleExponentialMovingAverage,
    [Category(IndicatorType.Momentum)]
    QuantitativeQualitativeEstimation,
    [Category(IndicatorType.Volatility)]
    QuasiWhiteNoise,
    [Category(IndicatorType.Trend)]
    QuickMovingAverage,
    [Category(IndicatorType.Momentum)]
    RateOfChange,
    [Category(IndicatorType.Momentum)]
    RelativeStrengthIndex,
    [Category(IndicatorType.Volatility)]
    RelativeVolatilityIndexV1,
    [Category(IndicatorType.Volatility)]
    RelativeVolatilityIndexV2,
    [Category(IndicatorType.Volume)]
    RelativeVolumeIndicator,
    [Category(IndicatorType.Momentum)]
    SchaffTrendCycle,
    [Category(IndicatorType.Trend)]
    SimpleMovingAverage,
    [Category(IndicatorType.Volatility)]
    StandardDeviation,
    [Category(IndicatorType.Trend)]
    StandardDeviationChannel,
    [Category(IndicatorType.Volatility)]
    StandardDeviationVolatility,
    [Category(IndicatorType.SupportAndResistance)]
    StandardPivotPoints,
    [Category(IndicatorType.Momentum)]
    StochasticOscillator,
    [Category(IndicatorType.Volatility)]
    StollerAverageRangeChannels,
    [Category(IndicatorType.Trend)]
    SuperTrend,
    [Category(IndicatorType.Trend)]
    SymmetricallyWeightedMovingAverage,
    [Category(IndicatorType.Trend)]
    T3MovingAverage,
    [Category(IndicatorType.Trend)]
    TriangularMovingAverage,
    [Category(IndicatorType.Trend)]
    Trimean,
    [Category(IndicatorType.Trend)]
    TripleExponentialMovingAverage,
    [Category(IndicatorType.Momentum)]
    Trix,
    [Category(IndicatorType.Momentum)]
    TrueStrengthIndex,
    [Category(IndicatorType.Trend)]
    TypicalPrice,
    [Category(IndicatorType.Trend)]
    UberTrendIndicator,
    [Category(IndicatorType.Momentum)]
    UhlMaCrossoverSystem,
    [Category(IndicatorType.Volatility)]
    UlcerIndex,
    [Category(IndicatorType.Momentum)]
    UltimateMomentumIndicator,
    [Category(IndicatorType.Trend)]
    UltimateMovingAverage,
    [Category(IndicatorType.Volatility)]
    UltimateMovingAverageBands,
    [Category(IndicatorType.Momentum)]
    UltimateOscillator,
    [Category(IndicatorType.Momentum)]
    UltimateTraderOscillator,
    [Category(IndicatorType.Volatility)]
    UltimateVolatilityIndicator,
    [Category(IndicatorType.SupportAndResistance)]
    UniChannel,
    [Category(IndicatorType.Volume)]
    UpsideDownsideVolume,
    [Category(IndicatorType.Volatility)]
    UpsidePotentialRatio,
    [Category(IndicatorType.Momentum)]
    ValueChartIndicator,
    [Category(IndicatorType.Trend)]
    VanillaABCDPattern,
    [Category(IndicatorType.Momentum)]
    VaradiOscillator,
    [Category(IndicatorType.Trend)]
    VariableAdaptiveMovingAverage,
    [Category(IndicatorType.Trend)]
    VariableIndexDynamicAverage,
    [Category(IndicatorType.Trend)]
    VariableLengthMovingAverage,
    [Category(IndicatorType.Trend)]
    VariableMovingAverage,
    [Category(IndicatorType.Volatility)]
    VariableMovingAverageBands,
    [Category(IndicatorType.Volatility)]
    VerticalHorizontalFilter,
    [Category(IndicatorType.Trend)]
    VerticalHorizontalMovingAverage,
    [Category(IndicatorType.Momentum)]
    VervoortHeikenAshiCandlestickOscillator,
    [Category(IndicatorType.Momentum)]
    VervoortHeikenAshiLongTermCandlestickOscillator,
    [Category(IndicatorType.Volatility)]
    VervoortModifiedBollingerBandIndicator,
    [Category(IndicatorType.Momentum)]
    VervoortSmoothedOscillator,
    [Category(IndicatorType.Volatility)]
    VervoortVolatilityBands,
    [Category(IndicatorType.Volatility)]
    VixTradingSystem,
    [Category(IndicatorType.Volatility)]
    VolatilityBasedMomentum,
    [Category(IndicatorType.Trend)]
    VolatilityIndexDynamicAverageIndicator,
    [Category(IndicatorType.Trend)]
    VolatilityMovingAverage,
    [Category(IndicatorType.Volatility)]
    VolatilityQualityIndex,
    [Category(IndicatorType.Volatility)]
    VolatilityRatio,
    [Category(IndicatorType.Volatility)]
    VolatilitySwitchIndicator,
    [Category(IndicatorType.Trend)]
    VolatilityWaveMovingAverage,
    [Category(IndicatorType.Volume)]
    VolumeAccumulationOscillator,
    [Category(IndicatorType.Volume)]
    VolumeAccumulationPercent,
    [Category(IndicatorType.Volume)]
    VolumeAdaptiveBands,
    [Category(IndicatorType.Trend)]
    VolumeAdjustedMovingAverage,
    [Category(IndicatorType.Volume)]
    VolumeFlowIndicator,
    [Category(IndicatorType.Volume)]
    VolumePositiveNegativeIndicator,
    [Category(IndicatorType.Volume)]
    VolumePriceConfirmationIndicator,
    [Category(IndicatorType.Trend)]
    VolumeWeightedAveragePrice,
    [Category(IndicatorType.Trend)]
    VolumeWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    VolumeWeightedRelativeStrengthIndex,
    [Category(IndicatorType.Trend)]
    VortexBands,
    [Category(IndicatorType.Trend)]
    VortexIndicator,
    [Category(IndicatorType.Momentum)]
    VostroIndicator,
    [Category(IndicatorType.Trend)]
    WaddahAttarExplosion,
    [Category(IndicatorType.Momentum)]
    WamiOscillator,
    [Category(IndicatorType.Momentum)]
    WaveTrendOscillator,
    [Category(IndicatorType.Trend)]
    WeightedClose,
    [Category(IndicatorType.Trend)]
    WeightedMovingAverage,
    [Category(IndicatorType.Trend)]
    WellRoundedMovingAverage,
    [Category(IndicatorType.Trend)]
    WellesWilderMovingAverage,
    [Category(IndicatorType.Trend)]
    WellesWilderSummation,
    [Category(IndicatorType.Volatility)]
    WellesWilderVolatilitySystem,
    [Category(IndicatorType.Momentum)]
    WilliamsAccumulationDistribution,
    [Category(IndicatorType.Momentum)]
    WilliamsFractals,
    [Category(IndicatorType.Momentum)]
    WilliamsR,
    [Category(IndicatorType.Momentum)]
    WilsonRelativePriceChannel,
    [Category(IndicatorType.Trend)]
    WindowedVolumeWeightedMovingAverage,
    [Category(IndicatorType.Momentum)]
    WoodieCommodityChannelIndex,
    [Category(IndicatorType.SupportAndResistance)]
    WoodiePivotPoints,
    [Category(IndicatorType.Volume)]
    ZDistanceFromVwap,
    [Category(IndicatorType.Momentum)]
    ZScore,
    [Category(IndicatorType.Trend)]
    ZeroLagExponentialMovingAverage,
    [Category(IndicatorType.Momentum)]
    ZeroLagSmoothedCycle,
    [Category(IndicatorType.Trend)]
    ZeroLagTripleExponentialMovingAverage,
    [Category(IndicatorType.Trend)]
    ZeroLowLagMovingAverage,
    [Category(IndicatorType.Momentum)]
    ZweigMarketBreadthIndicator
}
